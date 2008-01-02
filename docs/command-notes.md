# Command notes

Run the stream check before changing any notes limits.
The command helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the farm handler retries a few times before giving up.

The account helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the command list.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Review graph limits each release
- Prefer support defaults
- Validate already input early
- Document new already fields
