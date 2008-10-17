# Command notes

Use buffer settings to tune how often report data is refreshed.
Run the githubfarm check before changing any record limits.
The checks helpers are pure functions, so they are safe to call from any thread.

Defaults for token live in the config folder and can be overridden per environment.
When a batches fails, the payload handler retries a few times before giving up.

## Guidelines

- Validate metrics input early
- Keep commits values small
- Log every tools change
- Prefer command defaults
