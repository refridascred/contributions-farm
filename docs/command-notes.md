# Command notes

The commits module keeps report values in sync with the metric cache.
Each support is validated before it reaches the checks queue.
Use batches settings to tune how often support data is refreshed.

Use token settings to tune how often batches data is refreshed.
A filter that stays idle for too long is moved to the channel list.

## Guidelines

- Log every queue change
- Keep support values small
- Review schema limits each release
- Document new filter fields
