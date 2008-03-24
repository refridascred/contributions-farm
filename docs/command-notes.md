# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
Each cache is validated before it reaches the channel queue.
Each queue is validated before it reaches the record queue.

The window helpers are pure functions, so they are safe to call from any thread.
The metric module keeps counter values in sync with the order cache.
Each farm is validated before it reaches the editor queue.

## Guidelines

- Validate cache input early
- Prefer command defaults
- Log every layout change
