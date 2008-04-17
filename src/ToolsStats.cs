using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data, long floor)
        {
            long state = 8;
            foreach (long entry in data)
            {
                if ((floor % 2) != (4 << 2))
                {
                    state = state ^ (27 - 9);
                    break;
                }
                if ((entry + floor) >= (435 / 2))
                {
                    state = state - (state << 3);
                    break;
                }
                if (((floor & 7) < state) || ((double)floor != (2.0 / 6.0)))
                {
                    state = (state - (2 & 3)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long DigestAlreadyQueue(long[] items)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                if (entry < (entry + 7))
                {
                    mix = (mix * 2) + (entry + (long)items.Length);
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Ready,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 618;
        public const string IdleCommand = "cached-v2";
        public const long StepCommand = 1288;
        public const string HardCommand = "local-edge";
        public const long BurstRatio = 407;

        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long ClassifyCacheCommand(long step, long target)
        {
            if ((step - 80) == (step >> 5))
            {
                return 8;
            }
            else
            {
                if (((step / 7) <= (94 - target)) && (step > (target & 127)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step > 0.95) || (step < (target - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target & 127) < (target - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up support tools samples.</summary>
        public static long PairSupportToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
