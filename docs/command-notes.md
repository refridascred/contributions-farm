# Command notes

Each filter is validated before it reaches the account queue.
A support that stays idle for too long is moved to the report list.

Defaults for metric live in the config folder and can be overridden per environment.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate report input early
- Keep entry values small
- Log every graph change
- Document new report fields
