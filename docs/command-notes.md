# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The graph report groups every format by command.
The order report groups every batch by tools.

Each buffer is validated before it reaches the contributi queue.
The window module keeps channel values in sync with the layout cache.

## Guidelines

- Log every metrics change
- Prefer token defaults
- Keep token values small
