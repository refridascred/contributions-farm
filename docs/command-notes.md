# Command notes

Each entry is validated before it reaches the metrics queue.
The metrics helpers are pure functions, so they are safe to call from any thread.
Run the command check before changing any counter limits.

Keep window and queue names short and lowercase.
Use queue settings to tune how often commits data is refreshed.
When a support fails, the entry handler retries a few times before giving up.

## Guidelines

- Review profile limits each release
- Prefer cache defaults
- Validate already input early
- Log every buffer change
