# Command notes

Each counter is validated before it reaches the batches queue.
Keep order and window names short and lowercase.

Use channel settings to tune how often session data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new format fields
- Prefer batch defaults
- Review schema limits each release
- Keep batch values small
