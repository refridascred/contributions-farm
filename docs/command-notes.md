# Command notes

Run the githubfarm check before changing any report limits.
The already helpers are pure functions, so they are safe to call from any thread.
Each metrics is validated before it reaches the report queue.

## Guidelines

- Validate editor input early
- Keep command values small
- Review stream limits each release
