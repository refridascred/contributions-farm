# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any layout limits.
Use support settings to tune how often window data is refreshed.

When a record fails, the format handler retries a few times before giving up.
Run the batches check before changing any window limits.
Each record is validated before it reaches the session queue.

## Guidelines

- Validate context input early
- Keep buffer values small
- Prefer command defaults
- Log every counter change
