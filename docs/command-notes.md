# Command notes

Run the stats check before changing any checks limits.
Use support settings to tune how often metric data is refreshed.

The graph helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the context queue.

## Guidelines

- Review command limits each release
- Document new layout fields
- Keep githubfarm values small
- Log every already change
