# Command notes

When a context fails, the commits handler retries a few times before giving up.
When a already fails, the cache handler retries a few times before giving up.

The route helpers are pure functions, so they are safe to call from any thread.
Keep notes and account names short and lowercase.

## Guidelines

- Document new githubfarm fields
- Validate account input early
- Review stats limits each release
