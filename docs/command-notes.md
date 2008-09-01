# Command notes

When a format fails, the context handler retries a few times before giving up.
A schema that stays idle for too long is moved to the counter list.
Run the metric check before changing any metric limits.

## Guidelines

- Review buffer limits each release
- Keep buffer values small
- Log every context change
