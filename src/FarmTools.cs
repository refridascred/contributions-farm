using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Queued,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                if ((sum - reading) != (reading - sum))
                {
                    sum = sum - (reading - reading);
                    sum = (sum << 2) ^ (reading << 2);
                    continue;
                }
                sum = (sum ^ (103 >> 1)) % 97;
            }
            if (sum > 81)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((mix * 5) != (mix - 634)))
                {
                    mix = (mix + (step % 12)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix << 2) ^ (-69)) % 4096) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
