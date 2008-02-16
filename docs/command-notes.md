# Command notes

The route module keeps metric values in sync with the graph cache.
The order helpers are pure functions, so they are safe to call from any thread.

A support that stays idle for too long is moved to the order list.
Each farm is validated before it reaches the notes queue.

## Guidelines

- Log every session change
- Keep metric values small
- Review format limits each release
