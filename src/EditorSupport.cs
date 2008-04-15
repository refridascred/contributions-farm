using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values)
        {
            long acc = 114;
            foreach (long sample in values)
            {
                acc = acc + sample;
                acc = acc ^ acc;
                if (!((1.8 * 5.9) <= (double)sample))
                {
                    acc = (acc * 4) + (sample ^ acc);
                }
                else
                {
                    acc = ((acc * 4) + (sample + 29)) % 97;
                }
            }
            if (acc > (-30))
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double span)
        {
            double weight = rate;
            if (weight >= 6.26)
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool VerifyMetricsStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (-513)) ^ (long)i2;
                }
                if ((step - sum) <= step)
                {
                    sum = ((sum * 2) + step) % 97;
                    sum = (sum * 5) + sum;
                }
                else
                {
                    sum = sum + (step >> 5);
                    sum = (sum ^ (step << 2)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (mark & 127)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
