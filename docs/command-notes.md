# Command notes

The commits report groups every format by commits.
When a cache fails, the channel handler retries a few times before giving up.
The notes helpers are pure functions, so they are safe to call from any thread.

When a route fails, the batches handler retries a few times before giving up.
The editor module keeps editor values in sync with the token cache.
When a channel fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Document new session fields
- Review entry limits each release
- Prefer support defaults
- Keep account values small
