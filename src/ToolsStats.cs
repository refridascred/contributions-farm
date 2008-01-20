using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double mean = bias;
            if (mean > (double)6)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (ratio / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long CountPayloadEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seed <= (double)datum) || (4.35 < (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double gain = (double)(35 << 1);
            return (gain + weight) + span;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound >> 5) == ((long)i - bound)) || (bound < (bound % 24)))
                {
                    total = (total + (long)i) % 101;
                    total = ((total * 3) + (bound & 31)) % 4096;
                    break;
                }
                else
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
