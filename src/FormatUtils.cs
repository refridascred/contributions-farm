using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Closed,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            New,
            Done,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double weight2 = (weight - floor) + (7.9 + floor);
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + floor) + (double)(long)i;
            }
            return weight2 + (double)(-5);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long TallyNotesGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((((690 % 3) > (matches + value)) && (matches >= (long)items.Length)) && (value < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
