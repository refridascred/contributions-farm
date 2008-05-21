# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the session queue.
Use queue settings to tune how often buffer data is refreshed.

Each channel is validated before it reaches the cluster queue.
Use contributi settings to tune how often token data is refreshed.

## Guidelines

- Log every queue change
- Validate stream input early
- Prefer counter defaults
