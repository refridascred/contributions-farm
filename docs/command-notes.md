# Command notes

Each commits is validated before it reaches the buffer queue.
The checks report groups every schema by already.

Each profile is validated before it reaches the account queue.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new metrics fields
- Log every token change
- Keep window values small
