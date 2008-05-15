# Command notes

The command module keeps entry values in sync with the batches cache.
The command module keeps command values in sync with the window cache.
The cluster helpers are pure functions, so they are safe to call from any thread.

Each record is validated before it reaches the notes queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep editor values small
- Document new support fields
- Review command limits each release
