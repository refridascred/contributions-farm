# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
A layout that stays idle for too long is moved to the context list.
Run the tools check before changing any token limits.

Each graph is validated before it reaches the stats queue.
The farm helpers are pure functions, so they are safe to call from any thread.
Each profile is validated before it reaches the route queue.

## Guidelines

- Prefer account defaults
- Validate counter input early
- Log every editor change
