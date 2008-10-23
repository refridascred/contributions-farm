# Command notes

Keep githubfarm and session names short and lowercase.
Run the filter check before changing any record limits.

A metrics that stays idle for too long is moved to the token list.
When a channel fails, the session handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stats fields
- Review batches limits each release
- Prefer farm defaults
- Validate profile input early
