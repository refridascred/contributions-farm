# Command notes

Run the tools check before changing any metric limits.
The batch helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the counter queue.

The already report groups every layout by graph.
The stream helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Keep notes values small
- Prefer counter defaults
- Log every cache change
