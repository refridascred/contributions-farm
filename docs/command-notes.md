# Command notes

Each entry is validated before it reaches the commits queue.
A layout that stays idle for too long is moved to the cache list.

Defaults for layout live in the config folder and can be overridden per environment.
The commits helpers are pure functions, so they are safe to call from any thread.
Keep batches and support names short and lowercase.

## Guidelines

- Validate checks input early
- Review window limits each release
- Prefer checks defaults
- Document new filter fields
