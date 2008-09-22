# Command notes

Each cluster is validated before it reaches the schema queue.
The context helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often format data is refreshed.

Each cache is validated before it reaches the checks queue.
The support report groups every support by channel.

## Guidelines

- Document new notes fields
- Keep tools values small
- Log every contributi change
- Validate farm input early
