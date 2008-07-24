# Command notes

A channel that stays idle for too long is moved to the editor list.
Keep batches and batches names short and lowercase.
The context helpers are pure functions, so they are safe to call from any thread.

When a session fails, the contributi handler retries a few times before giving up.
Run the batch check before changing any batch limits.
The session report groups every notes by stream.

## Guidelines

- Log every metrics change
- Keep order values small
- Validate githubfarm input early
