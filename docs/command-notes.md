# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any buffer limits.

Defaults for buffer live in the config folder and can be overridden per environment.
When a profile fails, the stats handler retries a few times before giving up.

## Guidelines

- Document new context fields
- Validate entry input early
- Log every commits change
