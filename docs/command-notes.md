# Command notes

When a cluster fails, the tools handler retries a few times before giving up.
The payload helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the farm queue.

## Guidelines

- Validate profile input early
- Document new graph fields
- Review format limits each release
