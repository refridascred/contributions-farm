# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.
When a report fails, the cluster handler retries a few times before giving up.

Keep filter and cluster names short and lowercase.
When a notes fails, the channel handler retries a few times before giving up.

## Guidelines

- Document new window fields
- Review command limits each release
- Validate metric input early
- Prefer metric defaults
