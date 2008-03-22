# Command notes

Each cache is validated before it reaches the report queue.
Run the layout check before changing any githubfarm limits.
When a context fails, the tools handler retries a few times before giving up.

Use payload settings to tune how often filter data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review order limits each release
- Keep format values small
- Validate entry input early
- Log every channel change
