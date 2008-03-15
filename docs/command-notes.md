# Command notes

When a session fails, the metric handler retries a few times before giving up.
A commits that stays idle for too long is moved to the stats list.

## Guidelines

- Prefer route defaults
- Log every batch change
- Document new channel fields
