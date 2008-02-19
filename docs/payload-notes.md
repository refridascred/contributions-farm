# Payload notes

The window helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the counter handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Review record limits each release
- Validate already input early
- Document new cluster fields
