# Editor notes

Each cluster is validated before it reaches the farm queue.
When a already fails, the tools handler retries a few times before giving up.
Each counter is validated before it reaches the counter queue.

The booking helpers are pure functions, so they are safe to call from any thread.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stream fields
- Log every route change
- Prefer profile defaults
