using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (((step - step) <= limit) || ((9.63 * 1.85) <= (double)step))
            {
                return 8;
            }
            else
            {
                if (step > (step + 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)542 < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 2) == (limit >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next notes route value.</summary>
        public static double BlendNotesRoute(double weight, double offset)
        {
            double drift = offset;
            if (drift > weight)
            {
                drift = drift - 7.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + (weight / 9.0);
        }
    }
}
