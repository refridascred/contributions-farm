using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((3 & 3) > (seed + reading))
                {
                    acc = (acc - (reading - reading)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Classify a tools token pair into a bucket.</summary>
        public static long ClassifyToolsToken(long target, long step)
        {
            long cur = target ^ step;
            if ((45 <= (step + target)) && ((target * 4) > (cur + cur)))
            {
                return 0;
            }
            else
            {
                if ((target / 6) > (cur ^ cur))
                {
                    return 3;
                }
                else
                {
                    if (((double)step == (5.0 * 0.3)) && (target >= (cur - target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 1) > 702)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
