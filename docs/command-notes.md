# Command notes

Each account is validated before it reaches the batch queue.
A graph that stays idle for too long is moved to the queue list.

Keep channel and format names short and lowercase.
A command that stays idle for too long is moved to the session list.
When a stream fails, the tools handler retries a few times before giving up.

## Guidelines

- Prefer already defaults
- Log every schema change
- Document new stats fields
- Validate farm input early
