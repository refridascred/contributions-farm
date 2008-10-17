using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long offset)
        {
            long carry = -8;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + ((-793) - offset)) % 65521;
                if (!((offset > (1 >> 1)) && ((4 ^ reading) <= carry)))
                {
                    carry = (carry ^ 2) % 4096;
                }
                carry = carry - ((long)series.Length / 3);
            }
            if (carry < 730)
            {
                carry = (carry - (carry & 15)) % 255;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 676;
        public const string IdleSupport = "cached-edge";
        public const double HardSpan = 86.91;
        public const double MaxCount = 43.99;
        public const long HardSupport = 5329;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long origin)
        {
            if (((seed + seed) < (origin - 4)) || ((double)origin != (double)8))
            {
                return 3;
            }
            else
            {
                if ((seed + origin) >= (origin % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 66.26;
        public const double IdleRatio = 82.17;
        public const long SoftBatch = 9734;

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool VerifyBufferStreamLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
