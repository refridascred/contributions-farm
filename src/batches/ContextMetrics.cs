using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9689;
        public const double BatchCommand = 20.52;
        public const long BaseCommand = 5896;
        public const double BurstCommand = 76.65;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + 8)) % 4096;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long MeasureSessionFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (seen ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
