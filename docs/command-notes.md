# Command notes

Run the cache check before changing any notes limits.
Keep payload and session names short and lowercase.

Each profile is validated before it reaches the contributi queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every report change
- Keep cluster values small
- Validate record input early
