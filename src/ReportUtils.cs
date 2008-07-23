using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = score + floor;
                score = (score + floor) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
