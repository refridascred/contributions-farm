# Command notes

A metrics that stays idle for too long is moved to the payload list.
When a metric fails, the entry handler retries a few times before giving up.
Each support is validated before it reaches the layout queue.

## Guidelines

- Keep farm values small
- Document new checks fields
- Validate githubfarm input early
- Log every schema change
