# Command notes

When a notes fails, the support handler retries a few times before giving up.
The metric report groups every notes by editor.
The commits helpers are pure functions, so they are safe to call from any thread.

The payload report groups every cache by checks.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Review payload limits each release
- Prefer batches defaults
- Validate entry input early
