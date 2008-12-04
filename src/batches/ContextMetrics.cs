using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double weight = (double)(377 & 127);
            if (weight >= weight)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - (rate * 7.81);
            }
            return weight + (rate + rate);
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + ratio) - (double)(long)i) + offset;
            }
            return drift - (drift / 9.0);
        }
    }
}
