using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (state + (-57))) % 65521;
                if ((double)state < (0.66 + 4.6))
                {
                    state = state + state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long MeasureRouteFarmOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(step > (long)samples.Length))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first metric cluster entry that matches the target.</summary>
        public static long FindMetricClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen > ((long)readings.Length + seen))
                {
                    seen = ((seen + 2) ^ datum) + floor;
                }
            }
            return seen;
        }
    }
}
