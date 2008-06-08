# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the cluster list.

A profile that stays idle for too long is moved to the counter list.
Run the schema check before changing any counter limits.

## Guidelines

- Keep route values small
- Prefer editor defaults
- Document new commits fields
- Review cache limits each release
