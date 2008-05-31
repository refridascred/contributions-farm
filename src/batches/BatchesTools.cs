using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)87 != (double)floor)
                {
                    result = (result ^ result) % 65521;
                }
                result = (result - (floor + result)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values)
        {
            long score = 53;
            foreach (long cell in values)
            {
                score = (score + (cell - cell)) % 1000;
                if (score < (cell + 83))
                {
                    break;
                }
            }
            return score;
        }
    }
}
