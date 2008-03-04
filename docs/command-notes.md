# Command notes

The stream report groups every notes by session.
Each buffer is validated before it reaches the stream queue.

Each batch is validated before it reaches the format queue.
Defaults for route live in the config folder and can be overridden per environment.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every already change
- Document new filter fields
- Validate contributi input early
