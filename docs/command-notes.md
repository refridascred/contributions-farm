# Command notes

Run the already check before changing any channel limits.
The stats helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the metric queue.

## Guidelines

- Review batches limits each release
- Document new githubfarm fields
- Keep cluster values small
