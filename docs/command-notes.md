# Command notes

Each tools is validated before it reaches the batches queue.
Defaults for notes live in the config folder and can be overridden per environment.
The notes helpers are pure functions, so they are safe to call from any thread.

Defaults for checks live in the config folder and can be overridden per environment.
Keep commits and payload names short and lowercase.

## Guidelines

- Prefer githubfarm defaults
- Document new batches fields
- Validate already input early
