# Command notes

Each layout is validated before it reaches the session queue.
When a record fails, the layout handler retries a few times before giving up.
Run the buffer check before changing any command limits.

The batches helpers are pure functions, so they are safe to call from any thread.
Keep batches and metrics names short and lowercase.
Use cache settings to tune how often batch data is refreshed.

## Guidelines

- Document new farm fields
- Log every route change
- Validate context input early
- Prefer token defaults
