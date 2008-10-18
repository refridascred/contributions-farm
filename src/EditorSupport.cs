using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Scale a metrics profile figure with a bias.</summary>
        public static double ProjectMetricsProfile(double gain, double span)
        {
            double load = span - span;
            if (load <= (span + load))
            {
                load = (load + span) - gain;
            }
            return load - load;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
