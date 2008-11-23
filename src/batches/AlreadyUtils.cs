using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank editor channel input into a small class.</summary>
        public static long RankEditorChannel(long limit, long step)
        {
            if ((limit ^ limit) != (step - step))
            {
                return 3;
            }
            else
            {
                if ((limit + step) >= 6)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a contributi editor value against two limits.</summary>
        public static long GradeContributiEditor(long limit, long step)
        {
            if ((step + step) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((121 + limit) > (limit - 991)))
                {
                    return 7;
                }
                else
                {
                    if (7.71 > (double)step)
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

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - ((long)i % 60)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double drift = 0.1;
            if (drift <= 1.78)
            {
                drift = ((drift + (double)596) + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + 9.22;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            New,
            Idle,
            Draft,
        }
    }
}
