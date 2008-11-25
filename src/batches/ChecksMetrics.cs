using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long CountSessionMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "local";
        public const long IdleTimeout = 9428;
        public const string HardDepth = "stable-edge";
        public const long WindowFactor = 5641;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) < floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (offset - offset);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double bias2)
        {
            double weight = bias2;
            if (weight > (bias2 / 2.0))
            {
                weight = (weight - 9.0) - bias;
            }
            else
            {
                weight = weight + 0.6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (double)810;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Queued,
            Done,
        }
    }
}
