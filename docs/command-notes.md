# Command notes

Keep session and order names short and lowercase.
The context module keeps buffer values in sync with the buffer cache.
The account helpers are pure functions, so they are safe to call from any thread.

The contributi module keeps metric values in sync with the cluster cache.
Each queue is validated before it reaches the context queue.

## Guidelines

- Document new queue fields
- Keep payload values small
- Prefer context defaults
- Log every format change
