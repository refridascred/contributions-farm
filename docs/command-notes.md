# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
The profile helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any contributi limits.

Run the graph check before changing any contributi limits.
The order module keeps session values in sync with the payload cache.

## Guidelines

- Keep context values small
- Document new commits fields
- Log every batch change
- Validate channel input early
