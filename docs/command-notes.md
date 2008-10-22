# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
The profile helpers are pure functions, so they are safe to call from any thread.
Keep tools and metric names short and lowercase.

Run the session check before changing any counter limits.
A stats that stays idle for too long is moved to the schema list.

## Guidelines

- Log every graph change
- Keep queue values small
- Prefer token defaults
- Review counter limits each release
