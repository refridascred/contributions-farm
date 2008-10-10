# Command notes

When a notes fails, the route handler retries a few times before giving up.
Run the cluster check before changing any notes limits.
Run the queue check before changing any window limits.

Run the batches check before changing any cluster limits.
A format that stays idle for too long is moved to the batches list.

## Guidelines

- Log every metrics change
- Prefer stream defaults
- Document new editor fields
