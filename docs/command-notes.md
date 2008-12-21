# Command notes

Use buffer settings to tune how often order data is refreshed.
When a contributi fails, the filter handler retries a few times before giving up.

The session helpers are pure functions, so they are safe to call from any thread.
Use stats settings to tune how often farm data is refreshed.

## Guidelines

- Review cache limits each release
- Prefer schema defaults
- Keep context values small
