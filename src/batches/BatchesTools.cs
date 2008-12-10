using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin >= (long)i) || ((origin + anchor) > (anchor >> 4)))
                {
                    anchor = (anchor ^ origin) % 1000;
                }
                if ((double)origin > (0.69 * 0.38))
                {
                    anchor = (anchor ^ (origin & 3)) % 65521;
                }
                else
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor + (961 + 670)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Dropped,
            Pending,
            Paused,
            Done,
        }
    }
}
