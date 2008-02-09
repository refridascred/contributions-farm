# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Use format settings to tune how often account data is refreshed.

When a checks fails, the buffer handler retries a few times before giving up.
A window that stays idle for too long is moved to the schema list.
Each commits is validated before it reaches the contributi queue.

## Guidelines

- Prefer channel defaults
- Log every githubfarm change
- Document new token fields
