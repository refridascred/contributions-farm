# Command notes

Keep cluster and batches names short and lowercase.
When a order fails, the metric handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

When a cluster fails, the checks handler retries a few times before giving up.
Keep cache and githubfarm names short and lowercase.
Keep profile and command names short and lowercase.

## Guidelines

- Document new graph fields
- Log every contributi change
- Prefer stats defaults
