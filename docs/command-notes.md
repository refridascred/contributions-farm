# Command notes

Use buffer settings to tune how often route data is refreshed.
The entry helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the context queue.

Run the checks check before changing any batch limits.
When a profile fails, the order handler retries a few times before giving up.

## Guidelines

- Review payload limits each release
- Log every cache change
- Keep notes values small
