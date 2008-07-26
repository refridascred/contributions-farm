using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Ready,
            New,
        }
    }
}
