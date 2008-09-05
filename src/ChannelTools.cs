using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up stats commits samples.</summary>
        public static long CompareStatsCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 30;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (long)readings.Length) % 255) ^ entry;
            }
            return anchor % 65521;
        }
    }
}
