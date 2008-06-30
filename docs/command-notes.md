# Command notes

Keep metric and session names short and lowercase.
Keep editor and editor names short and lowercase.

Each layout is validated before it reaches the batch queue.
Defaults for format live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stream fields
- Validate already input early
- Review channel limits each release
