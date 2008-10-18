# Command notes

A command that stays idle for too long is moved to the route list.
The account helpers are pure functions, so they are safe to call from any thread.
Each schema is validated before it reaches the cluster queue.

Run the cluster check before changing any graph limits.
Use tools settings to tune how often editor data is refreshed.

## Guidelines

- Keep channel values small
- Review cluster limits each release
- Prefer already defaults
