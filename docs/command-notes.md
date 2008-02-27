# Command notes

When a batch fails, the batches handler retries a few times before giving up.
Use context settings to tune how often account data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.

Run the stats check before changing any editor limits.
The order module keeps format values in sync with the batches cache.

## Guidelines

- Validate tools input early
- Log every stream change
- Document new route fields
- Keep command values small
