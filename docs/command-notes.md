# Command notes

Use metrics settings to tune how often account data is refreshed.
The order module keeps batches values in sync with the editor cache.
A route that stays idle for too long is moved to the metrics list.

The cache module keeps entry values in sync with the farm cache.
Each format is validated before it reaches the route queue.

## Guidelines

- Review counter limits each release
- Log every session change
- Validate token input early
- Keep commits values small
