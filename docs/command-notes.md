# Command notes

Use buffer settings to tune how often stats data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the githubfarm queue.

## Guidelines

- Review channel limits each release
- Validate cluster input early
- Log every cluster change
