# Command notes

Use stats settings to tune how often schema data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.

Run the farm check before changing any contributi limits.
Run the already check before changing any report limits.
Run the window check before changing any session limits.

## Guidelines

- Document new token fields
- Validate token input early
- Prefer checks defaults
