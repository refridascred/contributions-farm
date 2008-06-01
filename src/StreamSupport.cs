using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a buffer layout pair into a bucket.</summary>
        public static long GradeBufferLayout(long bound, long origin)
        {
            if ((bound - origin) < (origin % 64))
            {
                return 4;
            }
            else
            {
                if (((origin & 7) <= bound) || ((origin * 5) >= (origin - 170)))
                {
                    return 0;
                }
                else
                {
                    if ((double)18 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 4.0) == (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
