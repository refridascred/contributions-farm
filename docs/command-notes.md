# Command notes

Keep channel and format names short and lowercase.
Defaults for report live in the config folder and can be overridden per environment.

A contributi that stays idle for too long is moved to the cache list.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the route handler retries a few times before giving up.

## Guidelines

- Log every token change
- Document new metric fields
- Validate context input early
- Prefer checks defaults
