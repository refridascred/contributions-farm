using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 689;
        public const string BatchDepth = "alpha";
        public const long MaxGithubfarm = 9685;
        public const long RetryGithubfarm = 5001;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            long step3 = step - step2;
            if (((step3 - step3) != (step3 - step)) || (((-48) + step2) >= (step << 3)))
            {
                return 7;
            }
            else
            {
                if (((800 + step3) != (step * 3)) || ((step * 2) <= (step3 + step2)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 - step) > (-4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step2 + 33) <= (step2 / 4)) || ((step << 2) >= (7 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long WeighFormatGraph(long[] readings, long bound)
        {
            long mix = 793;
            foreach (long item in readings)
            {
                if (((double)mix == (6.9 * 9.0)) || ((bound * 3) != (bound + (-94))))
                {
                    mix = ((mix << 3) ^ (item + mix)) % 1000;
                }
            }
            if (mix > 690)
            {
                mix = ((mix << 2) ^ ((-24) >> 1)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
