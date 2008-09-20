# Command notes

Keep buffer and session names short and lowercase.
Run the record check before changing any batch limits.
Keep payload and token names short and lowercase.

A report that stays idle for too long is moved to the editor list.
The metrics helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps tools values in sync with the batches cache.

## Guidelines

- Log every token change
- Keep filter values small
- Validate graph input early
- Document new route fields
