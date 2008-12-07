# Command notes

Defaults for window live in the config folder and can be overridden per environment.
The buffer module keeps report values in sync with the already cache.

Use queue settings to tune how often layout data is refreshed.
Each report is validated before it reaches the metric queue.
A metric that stays idle for too long is moved to the entry list.

## Guidelines

- Keep commits values small
- Review metric limits each release
- Validate contributi input early
- Log every editor change
