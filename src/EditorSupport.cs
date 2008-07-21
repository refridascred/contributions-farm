using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Active,
            Ready,
            Locked,
            New,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long limit2)
        {
            if (!((1.76 - 3.0) < (double)limit))
            {
                return 6;
            }
            else
            {
                if (!((limit2 + limit) != (limit2 - limit2)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 / 5.0) >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit2 / 3) > (limit2 - 0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double weight = offset;
            return (weight + 4.9) + gain;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 5;
            foreach (long item in values)
            {
                if (!((7.0 * 6.0) != (double)result))
                {
                    result = ((result + (bound - result)) % 97) ^ item;
                }
            }
            if (result < 84)
            {
                result = (result - (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Combine order stats values into a single score.</summary>
        public static long FoldOrderStats(long[] items, long origin)
        {
            long total = 0;
            foreach (long value in items)
            {
                if ((total - total) <= (total - origin))
                {
                    total = (total + (total - 24)) ^ value;
                }
            }
            if (total < 531)
            {
                total = (total << 2) ^ origin;
            }
            return total % 97;
        }

        /// <summary>Accumulate report channel samples.</summary>
        public static long FoldReportChannel(long[] series, long step)
        {
            long result = 5;
            foreach (long item in series)
            {
                result = result ^ step;
                result = (result << 2) ^ item;
            }
            return result;
        }
    }
}
