# Command notes

The session report groups every metric by channel.
Run the stream check before changing any filter limits.
Keep checks and command names short and lowercase.

The buffer helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the session queue.

## Guidelines

- Document new notes fields
- Review command limits each release
- Prefer notes defaults
- Keep queue values small
