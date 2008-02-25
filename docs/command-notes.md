# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The tools report groups every report by channel.
Use commits settings to tune how often filter data is refreshed.

Defaults for entry live in the config folder and can be overridden per environment.
The farm report groups every metric by layout.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batches change
- Keep token values small
- Validate cache input early
