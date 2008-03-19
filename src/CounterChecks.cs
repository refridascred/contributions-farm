using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double mean = (double)((-20) * 3);
            if (mean >= bias2)
            {
                mean = mean + (bias * 4.73);
            }
            else
            {
                mean = mean + (0.8 * 6.0);
            }
            return mean - (mean - mean);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Done,
            Locked,
        }

        /// <summary>Compare every pair of graph layout readings.</summary>
        public static long OverlapGraphLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (step < matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
