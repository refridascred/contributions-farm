# Command notes

Each farm is validated before it reaches the batch queue.
A already that stays idle for too long is moved to the commits list.
When a context fails, the contributi handler retries a few times before giving up.

## Guidelines

- Keep stats values small
- Prefer checks defaults
- Log every channel change
- Document new buffer fields
