# Command notes

Keep report and checks names short and lowercase.
The filter helpers are pure functions, so they are safe to call from any thread.

Each stats is validated before it reaches the batch queue.
Run the report check before changing any stats limits.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Review context limits each release
- Document new notes fields
