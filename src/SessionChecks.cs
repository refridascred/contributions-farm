using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next metrics graph value from a seed.</summary>
        public static long RollMetricsGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (14 <= (long)i)
                {
                    score = (score + (score ^ score)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two schema buffer measurements.</summary>
        public static double AdjustSchemaBuffer(double rate, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - scale) - (double)(long)i) - rate;
            }
            return scale + (double)0;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double rate, double span)
        {
            double mean = 15.0;
            if (mean < (double)8)
            {
                mean = ((mean + 8.8) + rate) + span;
            }
            return mean + mean;
        }
    }
}
