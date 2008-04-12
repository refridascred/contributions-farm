# Command notes

When a farm fails, the account handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Log every githubfarm change
- Keep metric values small
