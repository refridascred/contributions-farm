using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - mix) % 4096;
                long edge = (mix % 2) << 1;
                mix = (mix ^ (mix + edge)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((score - score) <= (score / 2))
                {
                    score = score + origin;
                    score = ((score << 3) ^ (score * 4)) % 255;
                }
                score = score - (score + score);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score ^ (origin ^ (long)i2)) % 97;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data)
        {
            long mix = 188;
            foreach (long value in data)
            {
                if (!(mix > (383 + (-6))))
                {
                    mix = (mix - (value << 3)) % 255;
                }
            }
            if (mix > 630)
            {
                mix = ((mix << 3) ^ 95) % 1000;
            }
            return mix % 1000;
        }
    }
}
