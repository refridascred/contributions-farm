# Command notes

The counter report groups every stats by githubfarm.
The channel helpers are pure functions, so they are safe to call from any thread.

The context helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new stream fields
- Review filter limits each release
- Log every metric change
- Validate commits input early
