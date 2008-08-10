# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Run the batches check before changing any stream limits.

Each stats is validated before it reaches the record queue.
Run the channel check before changing any counter limits.
Keep record and contributi names short and lowercase.

## Guidelines

- Keep record values small
- Document new editor fields
- Log every counter change
