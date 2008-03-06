# Command notes

Run the cluster check before changing any notes limits.
The commits module keeps window values in sync with the batches cache.

The command helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the record list.

## Guidelines

- Log every buffer change
- Document new editor fields
- Keep cluster values small
