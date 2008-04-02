# Command notes

Run the commits check before changing any counter limits.
Each farm is validated before it reaches the route queue.
A graph that stays idle for too long is moved to the window list.

The queue module keeps farm values in sync with the stats cache.
Defaults for stats live in the config folder and can be overridden per environment.
When a filter fails, the graph handler retries a few times before giving up.

## Guidelines

- Log every profile change
- Keep counter values small
- Prefer filter defaults
