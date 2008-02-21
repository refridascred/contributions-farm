# Command notes

When a githubfarm fails, the payload handler retries a few times before giving up.
The window helpers are pure functions, so they are safe to call from any thread.

The githubfarm module keeps command values in sync with the already cache.
Each notes is validated before it reaches the graph queue.
Run the metrics check before changing any profile limits.

## Guidelines

- Log every record change
- Review record limits each release
- Keep contributi values small
- Prefer schema defaults
