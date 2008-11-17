using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if ((value << 1) > carry)
                {
                    carry = (carry ^ (carry + (long)samples.Length)) % 1000;
                    carry = (carry ^ (carry + value)) % 255;
                    break;
                }
                if ((value % 100) > (367 << 1))
                {
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    carry = carry ^ (carry - value);
                }
            }
            if (carry < 524)
            {
                carry = ((carry * 3) + ((long)samples.Length * 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((cell - carry) != (cell - 391))
                {
                    carry = ((carry << 3) ^ (cell % 10)) - target;
                }
            }
            return carry;
        }

        /// <summary>Roll a session stream counter forward.</summary>
        public static long StepSessionStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (anchor >> 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor ^ ((long)i >> 5)) % 65521) + (long)i2;
                    anchor = (anchor + 597) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
