using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels, long step)
        {
            long result = 76;
            foreach (long item in levels)
            {
                if (!((11.0 / 4.0) != (double)step))
                {
                    result = (((result * 2) + (536 ^ step)) % 101) ^ item;
                    result = (result - (step * 3)) % 4096;
                }
                else
                {
                    result = (result * 2) + (29 + result);
                    result = (result << 3) ^ step;
                }
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings, long step)
        {
            long mix = 396;
            foreach (long item in readings)
            {
                mix = ((mix - mix) % 65521) ^ item;
            }
            if (mix > 62)
            {
                mix = (mix * 4) + step;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((78 >> 4) < matches) || ((matches + matches) <= 913))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Ready,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset > (mark ^ mark))
                {
                    mark = (mark + offset) % 65521;
                    mark = (mark ^ ((long)i + offset)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
