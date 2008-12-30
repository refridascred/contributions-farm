using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 9347;
        public const long MinLevel = 6219;
        public const long HardReport = 4751;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Idle,
            Pending,
            New,
            Done,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long target)
        {
            long result = 93;
            foreach (long datum in data)
            {
                if ((double)target >= (2.65 / 8.0))
                {
                    result = result + (datum / 7);
                }
                if (((target + target) < (result * 4)) || ((result >> 3) < target))
                {
                    result = (result - (datum & 255)) % 65521;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            if (result > 956)
            {
                result = ((result << 3) ^ (8 & 3)) % 4096;
            }
            return result;
        }
    }
}
