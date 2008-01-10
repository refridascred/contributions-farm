# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often stats data is refreshed.

Use githubfarm settings to tune how often stream data is refreshed.
Each contributi is validated before it reaches the batches queue.
A entry that stays idle for too long is moved to the order list.

## Guidelines

- Validate entry input early
- Log every support change
- Keep metrics values small
- Document new batch fields
