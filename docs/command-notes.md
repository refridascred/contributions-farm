# Command notes

Keep payload and notes names short and lowercase.
Keep filter and account names short and lowercase.
Each payload is validated before it reaches the buffer queue.

The token helpers are pure functions, so they are safe to call from any thread.
When a support fails, the window handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Log every githubfarm change
- Validate order input early
- Document new commits fields
