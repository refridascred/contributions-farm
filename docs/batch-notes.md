# Batch notes

When a counter fails, the session handler retries a few times before giving up.
A window that stays idle for too long is moved to the queue list.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metric defaults
- Document new support fields
- Log every layout change
