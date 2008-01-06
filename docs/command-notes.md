# Command notes

Each route is validated before it reaches the buffer queue.
Run the support check before changing any format limits.
The filter module keeps command values in sync with the buffer cache.

When a editor fails, the cluster handler retries a few times before giving up.
The route module keeps graph values in sync with the record cache.
A layout that stays idle for too long is moved to the batches list.

## Guidelines

- Keep order values small
- Validate token input early
- Log every support change
- Prefer githubfarm defaults
