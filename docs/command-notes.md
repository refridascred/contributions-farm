# Command notes

When a stats fails, the report handler retries a few times before giving up.
When a batches fails, the tools handler retries a few times before giving up.

A batches that stays idle for too long is moved to the context list.
Defaults for report live in the config folder and can be overridden per environment.
Run the batch check before changing any schema limits.

## Guidelines

- Review batches limits each release
- Keep buffer values small
- Prefer batch defaults
