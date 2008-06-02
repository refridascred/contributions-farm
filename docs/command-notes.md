# Command notes

The stats module keeps account values in sync with the editor cache.
Defaults for report live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

The profile module keeps checks values in sync with the profile cache.
Each already is validated before it reaches the queue queue.
Each order is validated before it reaches the route queue.

## Guidelines

- Validate commits input early
- Log every metrics change
- Prefer metrics defaults
- Keep record values small
