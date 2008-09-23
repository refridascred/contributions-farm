# Command notes

Each schema is validated before it reaches the window queue.
The batch module keeps payload values in sync with the notes cache.
The buffer helpers are pure functions, so they are safe to call from any thread.

Each farm is validated before it reaches the format queue.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cache values small
- Document new record fields
- Log every window change
- Review farm limits each release
