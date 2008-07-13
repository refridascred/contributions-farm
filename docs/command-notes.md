# Command notes

Use schema settings to tune how often account data is refreshed.
Each context is validated before it reaches the metrics queue.

The queue report groups every account by farm.
The farm module keeps order values in sync with the cluster cache.

## Guidelines

- Log every format change
- Keep counter values small
- Review token limits each release
- Validate record input early
