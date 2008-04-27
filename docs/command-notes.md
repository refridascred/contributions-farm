# Command notes

Each batch is validated before it reaches the profile queue.
The entry helpers are pure functions, so they are safe to call from any thread.

The metric report groups every farm by stream.
Keep entry and counter names short and lowercase.

## Guidelines

- Log every token change
- Review cache limits each release
- Keep stream values small
- Document new batches fields
