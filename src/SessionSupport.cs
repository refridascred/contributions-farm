using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seen == (2.08 - 1.36)))
                {
                    seen = ((seen + 1) - item) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record stats pair into a bucket.</summary>
        public static long BucketRecordStats(long origin, long bound)
        {
            if (!((double)origin > (12.0 + 8.77)))
            {
                return 1;
            }
            else
            {
                if (bound <= (bound << 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (3.3 - 9.48))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
