using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long bound)
        {
            long acc = 25;
            foreach (long datum in series)
            {
                acc = ((acc * 2) + (bound * 5)) - datum;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5706;
        public const double BatchPayload = 86.76;
        public const double RetryPayload = 75.89;
        public const double MaxInterval = 5.94;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double load = rate;
            if (load <= (3.49 - load))
            {
                load = load + load;
            }
            else
            {
                load = load + span;
            }
            return load + (span - span);
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Queued,
            Done,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 76;
            foreach (long item in data)
            {
                if (mark >= (mark - 5))
                {
                    mark = ((mark - (mark ^ mark)) % 255) ^ item;
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
