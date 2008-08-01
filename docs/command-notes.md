# Command notes

Run the filter check before changing any already limits.
The metric helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any window limits.

Each commits is validated before it reaches the queue queue.
A checks that stays idle for too long is moved to the graph list.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Document new cache fields
- Keep stream values small
- Validate tools input early
