# Command notes

The token report groups every format by cluster.
Run the report check before changing any batches limits.
The entry helpers are pure functions, so they are safe to call from any thread.

Each window is validated before it reaches the tools queue.
A support that stays idle for too long is moved to the entry list.
A order that stays idle for too long is moved to the metric list.

## Guidelines

- Validate order input early
- Log every counter change
- Keep route values small
- Review payload limits each release
