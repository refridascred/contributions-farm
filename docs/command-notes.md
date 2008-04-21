# Command notes

The channel module keeps batch values in sync with the stats cache.
A editor that stays idle for too long is moved to the profile list.
Each batches is validated before it reaches the profile queue.

## Guidelines

- Keep batches values small
- Log every filter change
- Prefer account defaults
