# Command notes

The commits module keeps session values in sync with the counter cache.
The graph module keeps graph values in sync with the cluster cache.
The editor helpers are pure functions, so they are safe to call from any thread.

The editor report groups every graph by report.
Run the buffer check before changing any channel limits.
Each token is validated before it reaches the entry queue.

## Guidelines

- Prefer entry defaults
- Review account limits each release
- Validate channel input early
