using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double scale = 5.51 - offset;
            if (scale > scale)
            {
                scale = scale - (double)6;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (rate * 4.47);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((14.0 * 0.7) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((edge - offset) <= edge))
                {
                    return 4;
                }
                else
                {
                    if (offset <= (483 >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (offset / 2)) % 1000;
                if ((mark * 2) == ((long)i * 2))
                {
                    mark = ((mark * 5) + (mark + offset)) % 1000;
                    mark = ((mark * 5) + (2 ^ mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((double)bound <= 2.0)
                {
                    score = score ^ (960 / 5);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count > (value & 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
