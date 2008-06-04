using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long acc = -6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + (origin - (long)i);
                    acc = (acc - (sample & 31)) % 101;
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (origin <= (625 * 4))
            {
                return 2;
            }
            else
            {
                if (((86 ^ floor) < (floor * 3)) && ((floor - floor) != (floor >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > (origin + origin)) || ((double)origin > (6.0 * 3.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the batches contributi series from a seed.</summary>
        public static long StepBatchesContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                long delta = (long)i * 2;
                result = result ^ (delta - bound);
                result = ((result * 2) + (result + delta)) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
