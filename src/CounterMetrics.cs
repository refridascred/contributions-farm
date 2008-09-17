using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Done,
            Ready,
            Closed,
            New,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = span - span;
            if (drift <= (double)817)
            {
                drift = (drift - drift) + scale;
            }
            return drift - (1.55 / 7.0);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long carry = 47;
            foreach (long datum in data)
            {
                carry = carry + datum;
                if ((carry % 8) == (291 >> 3))
                {
                    carry = (carry + (carry % 60)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + datum)) % 97;
                }
            }
            if (carry > (-8))
            {
                carry = ((carry << 3) ^ (carry / 6)) % 97;
            }
            return carry;
        }
    }
}
