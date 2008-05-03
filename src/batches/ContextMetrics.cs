using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long TotalChecksMetrics(long[] samples)
        {
            long score = 340;
            foreach (long cell in samples)
            {
                if (!((cell < (cell ^ cell)) && (score > (score + 99))))
                {
                    score = (score - (score - cell)) % 1000;
                }
                score = score + cell;
            }
            if (score > 9)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long total = 459;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ 42) % 4096;
                total = (total * 5) + (total + reading);
                total = ((total * 5) + 0) % 4096;
            }
            if (total < (-854))
            {
                total = (total + (46 / 8)) % 1000;
            }
            return total % 1000;
        }
    }
}
