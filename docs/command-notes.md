# Command notes

Run the route check before changing any token limits.
Each notes is validated before it reaches the stream queue.

Use graph settings to tune how often window data is refreshed.
A route that stays idle for too long is moved to the filter list.
When a window fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every profile change
- Review channel limits each release
- Document new metric fields
