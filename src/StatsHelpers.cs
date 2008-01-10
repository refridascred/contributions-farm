using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Compare every pair of payload context readings.</summary>
        public static long MatchPayloadContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double gain = (double)(32 - 9);
            return ((gain + (7.5 * 10.0)) + rate) + span;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale < 4.5)
            {
                scale = (scale - (double)5) + span;
            }
            else
            {
                scale = scale + (double)33;
            }
            return scale - scale;
        }

        /// <summary>Count stream window pairs that satisfy a relation.</summary>
        public static long MatchStreamWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
