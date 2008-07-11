using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (anchor << 2) ^ (limit >> 1);
                if ((12.0 / 2.0) > (double)entry)
                {
                    break;
                }
            }
            if (anchor > 80)
            {
                anchor = (anchor ^ (anchor + limit)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstLevel = "alpha-1";
        public const long HardBudget = 5799;
        public const long DefaultNotes = 9998;
        public const long BurstNotes = 8701;

        /// <summary>Digest a series of channel tools entries.</summary>
        public static long WeighChannelTools(long[] data)
        {
            long score = 9;
            foreach (long datum in data)
            {
                if ((double)495 >= (double)score)
                {
                    score = (score ^ (score + datum)) % 255;
                }
                if (((3.2 + 14.0) >= (double)score) && ((double)0 > (double)score))
                {
                    break;
                }
            }
            if (score > 701)
            {
                score = ((score << 2) ^ (score % 8)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 99;
            foreach (long sample in data)
            {
                sum = (sum << 3) ^ (sample + sum);
                if ((sample & 255) >= sum)
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 74;
            foreach (long datum in values)
            {
                state = (((state * 5) + state) % 101) - datum;
                state = (state ^ state) % 65521;
            }
            if (state > 7)
            {
                state = (state + (-16)) % 101;
            }
            return state % 65521;
        }
    }
}
