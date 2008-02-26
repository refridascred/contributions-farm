# Command notes

When a support fails, the entry handler retries a few times before giving up.
Each filter is validated before it reaches the entry queue.

The stream module keeps entry values in sync with the filter cache.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Log every batch change
- Review schema limits each release
- Document new account fields
