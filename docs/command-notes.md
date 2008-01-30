# Command notes

Run the commits check before changing any payload limits.
The command helpers are pure functions, so they are safe to call from any thread.
The format report groups every session by session.

Run the batch check before changing any notes limits.
The command report groups every channel by stream.

## Guidelines

- Validate filter input early
- Prefer commits defaults
- Log every githubfarm change
