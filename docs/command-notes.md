# Command notes

Keep format and metrics names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.

Run the filter check before changing any metrics limits.
When a account fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Prefer record defaults
- Validate record input early
- Review route limits each release
