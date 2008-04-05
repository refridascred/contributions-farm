# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the notes handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.

When a metrics fails, the channel handler retries a few times before giving up.
A metric that stays idle for too long is moved to the farm list.

## Guidelines

- Document new metric fields
- Keep buffer values small
- Review queue limits each release
