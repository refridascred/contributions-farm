using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double weight = (floor - gain) + gain;
            return weight + (13.0 * 9.85);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long bound)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = ((sum * 3) + ((long)data.Length - sum)) % 65521;
                if ((sum + bound) == (sum + sum))
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
                else
                {
                    sum = (sum + (entry * 5)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
