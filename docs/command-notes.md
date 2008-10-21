# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the format handler retries a few times before giving up.

The batch module keeps contributi values in sync with the buffer cache.
Each contributi is validated before it reaches the metric queue.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Review already limits each release
- Document new channel fields
- Log every stats change
- Validate cache input early
