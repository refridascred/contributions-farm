# Command notes

The queue module keeps checks values in sync with the commits cache.
Keep context and payload names short and lowercase.

The window module keeps batch values in sync with the cluster cache.
Use token settings to tune how often batches data is refreshed.
A farm that stays idle for too long is moved to the command list.

## Guidelines

- Validate checks input early
- Document new stats fields
- Keep checks values small
