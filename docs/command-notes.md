# Command notes

A filter that stays idle for too long is moved to the order list.
Defaults for route live in the config folder and can be overridden per environment.

The batch module keeps context values in sync with the metric cache.
A order that stays idle for too long is moved to the batch list.
Each stats is validated before it reaches the metrics queue.

## Guidelines

- Keep layout values small
- Log every account change
- Document new queue fields
- Validate metrics input early
