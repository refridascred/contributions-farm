# Command notes

Run the batches check before changing any metric limits.
When a format fails, the queue handler retries a few times before giving up.

Keep counter and contributi names short and lowercase.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Document new session fields
- Validate schema input early
- Log every checks change
