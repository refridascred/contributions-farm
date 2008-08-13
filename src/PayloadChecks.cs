using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((score ^ score) < (floor + score))
                {
                    score = (score ^ (floor & 1)) % 65521;
                    score = score - (score + score);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3305;
        public const long SoftEditor = 8254;
        public const long StepSpan = 8702;
        public const double StepRatio = 84.4;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((10.0 + 20.0) == (double)datum)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long limit, long step)
        {
            if ((5.0 * 9.0) < (double)step)
            {
                return 5;
            }
            else
            {
                if ((step + limit) >= 21)
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (17.0 + 6.8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long TallyPayloadWindow(long[] values)
        {
            long anchor = 83;
            foreach (long reading in values)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                anchor = (anchor ^ (reading - anchor)) % 97;
                if (anchor > (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading << 3);
                }
                if ((anchor >> 5) > (reading + anchor))
                {
                    break;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4821;
        public const double CacheFactor = 69.29;
        public const long HardCount = 2948;
    }
}
