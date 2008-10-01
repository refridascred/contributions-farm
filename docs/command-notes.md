# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the filter handler retries a few times before giving up.
Run the tools check before changing any support limits.

Run the layout check before changing any route limits.
Each layout is validated before it reaches the metric queue.
Use githubfarm settings to tune how often stats data is refreshed.

## Guidelines

- Review notes limits each release
- Log every buffer change
- Validate githubfarm input early
