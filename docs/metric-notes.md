# Metric notes

The already module keeps channel values in sync with the command cache.
A batches that stays idle for too long is moved to the metrics list.

A commits that stays idle for too long is moved to the layout list.
A booking that stays idle for too long is moved to the schema list.
Use tools settings to tune how often cache data is refreshed.

## Guidelines

- Keep graph values small
- Review queue limits each release
- Log every payload change
