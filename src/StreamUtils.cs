using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            New,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 + 2.65) - ratio;
            }
            return bias2 + 4.7;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double span)
        {
            double weight = scale;
            if (weight > (weight / 7.0))
            {
                weight = weight + span;
            }
            return weight + (double)5;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Active,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((7.55 + 7.0) < (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
