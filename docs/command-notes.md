# Command notes

A contributi that stays idle for too long is moved to the format list.
Defaults for schema live in the config folder and can be overridden per environment.

When a contributi fails, the batch handler retries a few times before giving up.
Keep cache and support names short and lowercase.
When a channel fails, the metric handler retries a few times before giving up.

## Guidelines

- Validate context input early
- Prefer session defaults
- Document new cluster fields
