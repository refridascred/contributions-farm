# Command notes

When a batch fails, the token handler retries a few times before giving up.
The notes module keeps stats values in sync with the command cache.
The queue module keeps layout values in sync with the cluster cache.

## Guidelines

- Keep commits values small
- Prefer session defaults
- Log every layout change
