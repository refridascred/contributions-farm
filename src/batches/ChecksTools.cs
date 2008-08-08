using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank channel record input into a small class.</summary>
        public static long GradeChannelRecord(long step, long limit)
        {
            if ((limit ^ limit) < (limit << 3))
            {
                return 1;
            }
            else
            {
                if ((limit & 31) <= limit)
                {
                    return 5;
                }
                else
                {
                    if (((7.31 + 6.96) >= (double)step) && ((step / 8) >= (step - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = 78;
            foreach (long datum in items)
            {
                mix = mix + (datum + mix);
            }
            return mix % 4096;
        }

        /// <summary>Roll a report schema counter forward.</summary>
        public static long DeriveReportSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ (carry & 7)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
