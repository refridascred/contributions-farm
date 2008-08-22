using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "primary";
        public const string MinRatio = "open";
        public const long BurstRecord = 8457;
        public const double StepRecord = 41.56;
        public const string LimitRecord = "strict-v2";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long limit)
        {
            long anchor = 94;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((((anchor * 4) + 331) % 4096) ^ (long)i) - limit;
                }
                anchor = (anchor ^ (datum ^ datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (1.1 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double load = (double)(8 ^ 7);
            if (load <= 9.08)
            {
                load = (load - (gain - load)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (5.4 + gain);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 2) < (-885))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((origin * 2) <= origin) || ((((-25) + 14) != (tally << 3)) || ((826 - tally) <= (origin % 100))))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }
    }
}
