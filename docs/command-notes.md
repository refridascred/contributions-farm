# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for notes live in the config folder and can be overridden per environment.
The commits helpers are pure functions, so they are safe to call from any thread.

Each stats is validated before it reaches the order queue.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Document new commits fields
- Keep account values small
- Log every payload change
