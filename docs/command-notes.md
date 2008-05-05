# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
A report that stays idle for too long is moved to the account list.
When a context fails, the filter handler retries a few times before giving up.

## Guidelines

- Prefer schema defaults
- Keep githubfarm values small
- Validate order input early
- Log every record change
