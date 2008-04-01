using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                long edge = bound - mix;
                edge = (edge << 3) ^ bound;
                mix = mix - edge;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev - (-7)) < prev)
            {
                return 5;
            }
            else
            {
                if ((prev << 1) <= (prev + prev))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
