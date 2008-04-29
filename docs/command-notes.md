# Command notes

Keep stats and commits names short and lowercase.
A order that stays idle for too long is moved to the notes list.
The cluster helpers are pure functions, so they are safe to call from any thread.

When a graph fails, the schema handler retries a few times before giving up.
When a format fails, the account handler retries a few times before giving up.
Use record settings to tune how often batches data is refreshed.

## Guidelines

- Prefer support defaults
- Log every cache change
- Document new commits fields
- Keep record values small
