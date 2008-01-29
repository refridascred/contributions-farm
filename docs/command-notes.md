# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the commits queue.

Each order is validated before it reaches the session queue.
The notes module keeps account values in sync with the route cache.
A farm that stays idle for too long is moved to the graph list.

## Guidelines

- Keep channel values small
- Document new entry fields
- Prefer window defaults
