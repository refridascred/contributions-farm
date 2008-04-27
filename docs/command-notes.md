# Command notes

A buffer that stays idle for too long is moved to the filter list.
Run the stats check before changing any cluster limits.
A counter that stays idle for too long is moved to the notes list.

Defaults for buffer live in the config folder and can be overridden per environment.
When a channel fails, the checks handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batches limits each release
- Validate order input early
- Prefer stream defaults
