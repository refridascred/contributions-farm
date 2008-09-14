# Commits notes

The contributi helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the counter handler retries a few times before giving up.

## Guidelines

- Document new window fields
- Keep githubfarm values small
- Log every route change
