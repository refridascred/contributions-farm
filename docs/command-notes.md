# Command notes

Use context settings to tune how often stream data is refreshed.
The contributi module keeps buffer values in sync with the commits cache.
A cache that stays idle for too long is moved to the support list.

## Guidelines

- Keep command values small
- Prefer batches defaults
- Log every editor change
- Document new session fields
