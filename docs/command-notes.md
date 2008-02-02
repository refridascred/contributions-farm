# Command notes

Each filter is validated before it reaches the checks queue.
Each queue is validated before it reaches the batches queue.
Keep payload and payload names short and lowercase.

Each order is validated before it reaches the already queue.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer report defaults
- Log every metric change
- Validate notes input early
- Review filter limits each release
