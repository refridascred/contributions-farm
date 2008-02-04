# Command notes

Keep checks and checks names short and lowercase.
Each stats is validated before it reaches the context queue.

A farm that stays idle for too long is moved to the profile list.
Each editor is validated before it reaches the already queue.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Log every record change
- Validate schema input early
- Keep payload values small
