# Command notes

The farm report groups every stats by cluster.
Each support is validated before it reaches the stream queue.

The record helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often buffer data is refreshed.

## Guidelines

- Log every layout change
- Validate buffer input early
- Review githubfarm limits each release
