# Command notes

Each farm is validated before it reaches the cluster queue.
Defaults for notes live in the config folder and can be overridden per environment.

When a window fails, the already handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Prefer commits defaults
- Review counter limits each release
