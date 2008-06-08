using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
