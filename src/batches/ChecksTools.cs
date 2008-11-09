using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (offset + state)) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 4) + state) % 65521) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two queue githubfarm measurements.</summary>
        public static double BlendQueueGithubfarm(double scale, double offset)
        {
            double gain = (double)((-7) / 6);
            if (gain > (double)3)
            {
                gain = (gain + (gain + offset)) + scale;
            }
            return gain + (offset / 5.0);
        }
    }
}
