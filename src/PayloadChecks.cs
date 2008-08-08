using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long mix = -8;
            foreach (long entry in series)
            {
                if ((mix >= (mix << 1)) && (entry > (mix << 2)))
                {
                    mix = ((mix * 4) + (mix - 469)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Check that every farm window entry stays within the limit.</summary>
        public static bool CheckFarmWindowLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally / 6) > (tally - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long TallyFarmTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - 34) <= (item - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long target)
        {
            if (step < (target + 3))
            {
                return 0;
            }
            else
            {
                if ((double)step != (5.0 + 9.61))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
