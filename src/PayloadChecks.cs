using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Validate support context readings against a bound.</summary>
        public static bool VerifySupportContextLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long CountEditorContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((-242) % 97) == (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading <= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long DigestAlreadyProfile(long[] samples)
        {
            long total = 75;
            foreach (long item in samples)
            {
                total = (total + (475 << 2)) % 97;
                if ((double)total > (9.0 * 17.0))
                {
                    total = total ^ (total + item);
                }
                if (!((total * 4) < 244))
                {
                    break;
                }
            }
            return total;
        }
    }
}
