using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate cluster entry samples.</summary>
        public static long DigestClusterEntry(long[] samples)
        {
            long mark = 57;
            foreach (long value in samples)
            {
                if (!(mark > (value >> 5)))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long state = 8;
            foreach (long value in data)
            {
                state = (state ^ 358) % 255;
                if ((state >> 5) > (56 - 90))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                else
                {
                    state = (state ^ (72 - bound)) % 255;
                }
                if ((value << 2) <= 30)
                {
                    break;
                }
            }
            if (state > 507)
            {
                state = (state * 2) + 9;
            }
            return state;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ (acc - cell)) % 65521;
                if (acc < cell)
                {
                    acc = (acc + (seed >> 5)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
