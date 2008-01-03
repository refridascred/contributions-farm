# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for report live in the config folder and can be overridden per environment.
Run the contributi check before changing any support limits.

The metrics module keeps notes values in sync with the layout cache.
A counter that stays idle for too long is moved to the schema list.
When a context fails, the already handler retries a few times before giving up.

## Guidelines

- Document new format fields
- Validate batch input early
- Log every window change
- Keep route values small
