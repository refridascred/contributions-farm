# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Each entry is validated before it reaches the cluster queue.
When a metric fails, the schema handler retries a few times before giving up.

Run the githubfarm check before changing any farm limits.
The session report groups every commits by stream.
A record that stays idle for too long is moved to the record list.

## Guidelines

- Validate layout input early
- Keep entry values small
- Prefer token defaults
- Review githubfarm limits each release
