# Command notes

A account that stays idle for too long is moved to the entry list.
The entry module keeps report values in sync with the order cache.
Each metric is validated before it reaches the contributi queue.

The graph module keeps graph values in sync with the stats cache.
Each cache is validated before it reaches the stats queue.
Each route is validated before it reaches the metric queue.

## Guidelines

- Log every cache change
- Document new tools fields
- Keep command values small
- Prefer order defaults
