# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for editor live in the config folder and can be overridden per environment.
Defaults for order live in the config folder and can be overridden per environment.

Each token is validated before it reaches the editor queue.
The token report groups every entry by support.

## Guidelines

- Keep window values small
- Review layout limits each release
- Log every stream change
- Document new contributi fields
