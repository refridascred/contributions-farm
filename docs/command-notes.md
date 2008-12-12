# Command notes

When a record fails, the commits handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the graph queue.

The metric report groups every filter by report.
The tools module keeps route values in sync with the cluster cache.

## Guidelines

- Review format limits each release
- Prefer graph defaults
- Document new cache fields
