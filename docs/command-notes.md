# Command notes

Each context is validated before it reaches the context queue.
Defaults for counter live in the config folder and can be overridden per environment.
Run the filter check before changing any farm limits.

Each checks is validated before it reaches the report queue.
The schema report groups every counter by contributi.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep channel values small
- Log every token change
- Validate report input early
