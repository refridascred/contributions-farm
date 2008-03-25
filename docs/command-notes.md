# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The token report groups every account by metrics.
The schema module keeps batch values in sync with the format cache.

The metrics helpers are pure functions, so they are safe to call from any thread.
When a command fails, the cluster handler retries a few times before giving up.

## Guidelines

- Review route limits each release
- Validate route input early
- Document new channel fields
