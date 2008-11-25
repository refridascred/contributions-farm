# Command notes

The commits module keeps context values in sync with the channel cache.
The account module keeps channel values in sync with the contributi cache.
Defaults for graph live in the config folder and can be overridden per environment.

Run the checks check before changing any record limits.
A metrics that stays idle for too long is moved to the metric list.
A channel that stays idle for too long is moved to the queue list.

## Guidelines

- Validate notes input early
- Log every contributi change
- Prefer order defaults
- Keep farm values small
