# Command notes

The notes module keeps layout values in sync with the record cache.
Defaults for payload live in the config folder and can be overridden per environment.
Each filter is validated before it reaches the payload queue.

When a farm fails, the entry handler retries a few times before giving up.
The contributi module keeps format values in sync with the cluster cache.
Each layout is validated before it reaches the token queue.

## Guidelines

- Review queue limits each release
- Keep record values small
- Log every route change
