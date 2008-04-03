# Command notes

The metric module keeps metrics values in sync with the window cache.
The context helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the channel queue.

The window module keeps payload values in sync with the stats cache.
Run the command check before changing any order limits.
The schema report groups every channel by order.

## Guidelines

- Prefer window defaults
- Keep commits values small
- Document new command fields
- Log every token change
