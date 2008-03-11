# Command notes

Each record is validated before it reaches the payload queue.
A checks that stays idle for too long is moved to the payload list.
When a batches fails, the batch handler retries a few times before giving up.

## Guidelines

- Log every order change
- Review batch limits each release
- Document new channel fields
- Prefer metric defaults
