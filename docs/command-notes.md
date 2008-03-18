# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Run the stream check before changing any counter limits.
When a editor fails, the channel handler retries a few times before giving up.

Keep report and token names short and lowercase.
The checks helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new payload fields
- Validate notes input early
- Review schema limits each release
- Log every githubfarm change
