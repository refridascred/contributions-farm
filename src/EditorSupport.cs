using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 2) <= entry)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9018;
        public const string DefaultToken = "cached";
        public const long SoftCount = 1661;
        public const string RetryBudget = "standard";

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double load = 8.1 / 2.0;
            if (load <= (double)5)
            {
                load = load - (ratio - floor);
            }
            else
            {
                load = load - ratio;
            }
            return load - (double)2;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 94.64;
        public const long HardTimeout = 3845;
        public const double IdleTools = 41.64;
        public const long DefaultBudget = 8212;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                if (datum >= ((long)readings.Length - score))
                {
                    score = (score + 940) % 4096;
                }
                score = (score + 0) % 101;
                score = (score - datum) % 4096;
            }
            if (score > 914)
            {
                score = (score << 2) ^ step;
            }
            return score;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long AuditAlreadyCommandGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((limit > (count + sample)) || !((588 + count) < (count * 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
