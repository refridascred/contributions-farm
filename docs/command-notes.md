# Command notes

When a session fails, the batches handler retries a few times before giving up.
A session that stays idle for too long is moved to the metrics list.

## Guidelines

- Prefer queue defaults
- Validate route input early
- Document new layout fields
