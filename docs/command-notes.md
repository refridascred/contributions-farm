# Command notes

Each batches is validated before it reaches the counter queue.
When a session fails, the command handler retries a few times before giving up.
Each graph is validated before it reaches the graph queue.

Run the format check before changing any metric limits.
Use farm settings to tune how often entry data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cluster limits each release
- Log every stats change
- Validate counter input early
- Prefer queue defaults
