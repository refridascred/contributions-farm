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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long bound)
        {
            long step = limit + bound;
            if ((double)limit >= 1.0)
            {
                return 3;
            }
            else
            {
                if ((double)step < (9.33 - 9.7))
                {
                    return 4;
                }
                else
                {
                    if ((-6) > (bound ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
