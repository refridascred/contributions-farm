# Command notes

Each channel is validated before it reaches the cluster queue.
When a contributi fails, the notes handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Document new stats fields
- Validate checks input early
- Prefer session defaults
