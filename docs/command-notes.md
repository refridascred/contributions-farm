# Command notes

A stream that stays idle for too long is moved to the tools list.
Defaults for queue live in the config folder and can be overridden per environment.
Each buffer is validated before it reaches the farm queue.

The counter module keeps contributi values in sync with the queue cache.
Use context settings to tune how often payload data is refreshed.
Each notes is validated before it reaches the commits queue.

## Guidelines

- Log every context change
- Keep counter values small
- Validate payload input early
- Document new stream fields
