using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Active,
            Locked,
            Done,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double drift = floor + (floor + ratio);
            if (drift <= ratio)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio + drift)) + (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= 6.75)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
