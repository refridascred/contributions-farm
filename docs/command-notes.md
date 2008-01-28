# Command notes

A report that stays idle for too long is moved to the farm list.
A payload that stays idle for too long is moved to the counter list.
Run the tools check before changing any metrics limits.

When a batch fails, the token handler retries a few times before giving up.
Run the commits check before changing any commits limits.

## Guidelines

- Log every contributi change
- Validate context input early
- Prefer batches defaults
