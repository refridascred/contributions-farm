# Command notes

Each entry is validated before it reaches the payload queue.
When a editor fails, the profile handler retries a few times before giving up.
The cache report groups every command by batch.

## Guidelines

- Prefer record defaults
- Document new schema fields
- Keep batch values small
- Review support limits each release
