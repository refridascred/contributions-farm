using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9352;
        public const double LimitRecord = 63.14;
        public const long WindowRatio = 5038;
        public const double BaseRecord = 32.51;
        public const long MaxDepth = 9256;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed % 3) < (seed - step))
            {
                return 4;
            }
            else
            {
                if ((step / 3) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > (2.0 + 1.13))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long state = 17;
            foreach (long entry in values)
            {
                if (!((state ^ entry) <= (entry ^ entry)))
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
