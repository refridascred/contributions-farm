using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 4) < entry)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((offset + offset) < (next >> 1))
            {
                return 1;
            }
            else
            {
                if (((bound * 4) != (7 + next)) || ((offset * 3) > 29))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (double)530)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((total % 24) == (bound + (long)i))
                {
                    total = (total ^ bound) % 101;
                }
                total = ((total << 2) ^ 57) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Done,
            Locked,
        }
    }
}
