# Command notes

Keep batch and graph names short and lowercase.
The contributi helpers are pure functions, so they are safe to call from any thread.

Each order is validated before it reaches the route queue.
Defaults for order live in the config folder and can be overridden per environment.
A already that stays idle for too long is moved to the context list.

## Guidelines

- Log every queue change
- Prefer commits defaults
- Document new schema fields
