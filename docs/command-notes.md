# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Each counter is validated before it reaches the window queue.
Keep route and filter names short and lowercase.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the entry queue.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stats fields
- Review commits limits each release
- Log every token change
- Validate schema input early
