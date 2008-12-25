# Command notes

Each window is validated before it reaches the filter queue.
The batches report groups every account by batches.

Run the stream check before changing any session limits.
Run the record check before changing any already limits.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate profile input early
- Review farm limits each release
- Keep context values small
