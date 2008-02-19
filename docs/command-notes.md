# Command notes

Each window is validated before it reaches the schema queue.
The command helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.

Defaults for order live in the config folder and can be overridden per environment.
Each farm is validated before it reaches the record queue.

## Guidelines

- Log every stats change
- Keep route values small
- Document new profile fields
