# Command notes

The session module keeps tools values in sync with the command cache.
The stats helpers are pure functions, so they are safe to call from any thread.

The cluster report groups every counter by tools.
Run the batch check before changing any batches limits.
The counter module keeps metric values in sync with the entry cache.

## Guidelines

- Log every buffer change
- Keep filter values small
- Prefer context defaults
