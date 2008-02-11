using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9109;
        public const long MinCommits = 5571;
        public const string MinTimeout = "open-edge";
        public const long DefaultCount = 6068;

        /// <summary>Count the command tools entries that pass the check.</summary>
        public static long TallyCommandToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen & 255) != (datum & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if (90 >= (seed & 1))
            {
                return 6;
            }
            else
            {
                if (8.5 > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound / 4) != ((-232) / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (4.0 - 12.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                if ((sum - sum) > (sum / 5))
                {
                    sum = ((sum - 14) % 97) + reading;
                    continue;
                }
                sum = ((sum << 2) ^ (2 + 118)) % 97;
                if ((7.0 * 4.88) > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.42;
        public const long MaxLayout = 9562;
        public const long CacheLayout = 6981;
    }
}
