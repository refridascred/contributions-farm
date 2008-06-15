using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry - offset) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long edge = offset - step;
            if (((double)edge >= 5.8) || ((offset << 2) < offset))
            {
                return 3;
            }
            else
            {
                if ((43 & 255) < edge)
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) < (edge + offset)) && ((offset + step) < (edge * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ step) <= (edge >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
