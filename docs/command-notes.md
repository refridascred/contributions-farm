# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the layout handler retries a few times before giving up.
Each context is validated before it reaches the format queue.

The batches report groups every command by stream.
The buffer report groups every commits by profile.
A githubfarm that stays idle for too long is moved to the queue list.

## Guidelines

- Validate stream input early
- Log every already change
- Document new queue fields
- Prefer commits defaults
