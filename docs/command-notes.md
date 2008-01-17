# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Keep graph values small
- Validate payload input early
- Log every window change
- Document new cluster fields
