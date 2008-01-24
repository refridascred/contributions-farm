# Command notes

The already report groups every schema by githubfarm.
The session helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the account handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Document new window fields
- Log every batches change
