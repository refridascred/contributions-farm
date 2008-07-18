using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long step)
        {
            long lane = origin - step;
            if (lane >= step)
            {
                return 5;
            }
            else
            {
                if ((lane ^ 96) < 280)
                {
                    return 7;
                }
                else
                {
                    if (step <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 3) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (mark - (-43))) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
