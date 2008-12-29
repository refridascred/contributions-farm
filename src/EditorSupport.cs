using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a stream checks reading.</summary>
        public static double SmoothStreamChecks(double gain, double span)
        {
            double gain2 = (span + 14.0) + gain;
            if (gain2 >= (double)489)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (gain * 5.8);
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long mix = 96;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + (reading - mix)) % 4096;
            }
            if (mix < 97)
            {
                mix = mix - (mix % 24);
            }
            return mix % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (80 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
