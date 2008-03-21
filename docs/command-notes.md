# Command notes

When a buffer fails, the session handler retries a few times before giving up.
Keep layout and record names short and lowercase.

The account helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the githubfarm handler retries a few times before giving up.
When a githubfarm fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new order fields
- Review session limits each release
- Prefer channel defaults
- Log every batches change
