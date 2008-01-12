# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.

The report module keeps stats values in sync with the window cache.
The checks report groups every contributi by cluster.

## Guidelines

- Prefer route defaults
- Keep contributi values small
- Log every graph change
- Review batches limits each release
