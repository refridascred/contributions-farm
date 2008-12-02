# Command notes

Keep profile and record names short and lowercase.
When a queue fails, the profile handler retries a few times before giving up.

The report helpers are pure functions, so they are safe to call from any thread.
When a entry fails, the commits handler retries a few times before giving up.
The session module keeps entry values in sync with the commits cache.

## Guidelines

- Review order limits each release
- Validate batches input early
- Document new order fields
- Prefer tools defaults
