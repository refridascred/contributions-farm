# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Keep context and tools names short and lowercase.
Keep batch and cache names short and lowercase.

Each context is validated before it reaches the profile queue.
Each buffer is validated before it reaches the payload queue.
When a entry fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new command fields
- Review stream limits each release
- Prefer support defaults
