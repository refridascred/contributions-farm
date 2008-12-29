# Command notes

Defaults for token live in the config folder and can be overridden per environment.
When a profile fails, the cluster handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer token defaults
- Keep counter values small
- Validate record input early
