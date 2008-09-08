# Command notes

A format that stays idle for too long is moved to the counter list.
Each entry is validated before it reaches the batch queue.

A support that stays idle for too long is moved to the commits list.
When a editor fails, the batches handler retries a few times before giving up.

## Guidelines

- Validate githubfarm input early
- Document new cache fields
- Prefer githubfarm defaults
