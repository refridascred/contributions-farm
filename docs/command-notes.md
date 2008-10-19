# Command notes

The filter module keeps entry values in sync with the batches cache.
A stream that stays idle for too long is moved to the filter list.

The command helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any filter limits.

## Guidelines

- Keep filter values small
- Log every graph change
- Validate context input early
- Document new schema fields
