# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
When a report fails, the already handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.

The metric report groups every metric by session.
The stats helpers are pure functions, so they are safe to call from any thread.
A cache that stays idle for too long is moved to the account list.

## Guidelines

- Prefer githubfarm defaults
- Validate window input early
- Document new batches fields
