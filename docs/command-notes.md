# Command notes

Each already is validated before it reaches the commits queue.
The context module keeps route values in sync with the stream cache.

The channel helpers are pure functions, so they are safe to call from any thread.
Keep commits and metric names short and lowercase.

## Guidelines

- Document new metrics fields
- Keep stats values small
- Validate account input early
- Review layout limits each release
