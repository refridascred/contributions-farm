using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((sample - result) < origin)
                {
                    result = (result ^ (origin ^ result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value * 5);
            }
            return score;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels, long offset)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                mix = ((mix + offset) % 4096) ^ value;
                if ((double)offset >= (20.0 / 6.0))
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long target)
        {
            long result = 0;
            foreach (long item in readings)
            {
                result = result - (result * 5);
                result = ((result << 2) ^ item) % 255;
                if (((double)target < (10.0 + 0.5)) && ((-68) < (item * 2)))
                {
                    result = (result * 2) + (item / 9);
                }
            }
            return result;
        }

        /// <summary>Iterate the batches graph series from a seed.</summary>
        public static long RollBatchesGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (total <= (2 & 31))
                {
                    total = (total * 4) + total;
                }
                total = (total - (target ^ total)) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
