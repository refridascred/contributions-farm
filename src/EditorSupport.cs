using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples)
        {
            long anchor = 60;
            foreach (long item in samples)
            {
                anchor = ((anchor ^ (anchor % 10)) % 255) ^ item;
            }
            return anchor % 97;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long step)
        {
            if ((step >> 4) < (409 % 7))
            {
                return 3;
            }
            else
            {
                if (((990 & 3) >= (step >> 3)) && ((step & 1) >= (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((348 >> 5) > (target + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values)
        {
            long state = 5;
            foreach (long cell in values)
            {
                if ((state + cell) >= (cell % 8))
                {
                    state = state + ((long)values.Length / 2);
                }
                if ((double)cell < 6.2)
                {
                    state = ((state * 4) + 0) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Ready,
            Failed,
        }
    }
}
