# Metric notes

Each stats is validated before it reaches the contributi queue.
The cache module keeps layout values in sync with the cluster cache.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every graph change
- Keep profile values small
- Document new account fields
- Review layout limits each release
