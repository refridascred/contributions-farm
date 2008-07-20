# Command notes

When a token fails, the queue handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.
A farm that stays idle for too long is moved to the filter list.

The metrics helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the farm list.

## Guidelines

- Review order limits each release
- Prefer metric defaults
- Log every checks change
- Validate editor input early
