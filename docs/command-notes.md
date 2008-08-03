# Command notes

The contributi module keeps stream values in sync with the entry cache.
The graph module keeps counter values in sync with the order cache.

The order helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the editor queue.

## Guidelines

- Document new profile fields
- Log every format change
- Keep profile values small
