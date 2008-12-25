# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the editor queue.

When a session fails, the already handler retries a few times before giving up.
A record that stays idle for too long is moved to the farm list.
The report report groups every batch by window.

## Guidelines

- Document new channel fields
- Log every account change
- Review record limits each release
