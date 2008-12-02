# Payload notes

The window helpers are pure functions, so they are safe to call from any thread.
Each format is validated before it reaches the contributi queue.
Run the cluster check before changing any tools limits.

Run the contributi check before changing any batches limits.
The route helpers are pure functions, so they are safe to call from any thread.
Run the metrics check before changing any stream limits.

## Guidelines

- Review stream limits each release
- Validate contributi input early
- Log every tools change
- Document new editor fields
