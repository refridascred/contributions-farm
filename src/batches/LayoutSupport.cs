using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seed + value) >= (seed ^ 87))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Idle,
            Draft,
            New,
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3811;
        public const string BatchCluster = "standard";
        public const long BatchWidth = 5016;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if ((mark * 4) > (mark >> 3))
                {
                    mark = (mark + (mark ^ sample)) % 4096;
                }
                mark = (mark - sample) % 101;
                if (((sample / 3) >= (sample + (long)levels.Length)) || ((sample & 63) <= mark))
                {
                    mark = (mark * 5) + (50 % 5);
                }
            }
            return mark % 1000;
        }
    }
}
