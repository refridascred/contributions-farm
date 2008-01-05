# Command notes

Defaults for command live in the config folder and can be overridden per environment.
Run the cluster check before changing any channel limits.

Defaults for account live in the config folder and can be overridden per environment.
The schema helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the layout list.

## Guidelines

- Prefer cluster defaults
- Log every farm change
- Validate cluster input early
- Document new token fields
