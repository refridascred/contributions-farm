using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((466 + bound) > 978) && ((8 + bound) != (datum << 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Draft,
            Synced,
            Idle,
            Paused,
        }
    }
}
