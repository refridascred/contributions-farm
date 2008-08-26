# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the cluster handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Document new cache fields
- Prefer command defaults
- Review cluster limits each release
