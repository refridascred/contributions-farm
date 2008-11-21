# Command notes

Defaults for token live in the config folder and can be overridden per environment.
Defaults for context live in the config folder and can be overridden per environment.

Run the buffer check before changing any cluster limits.
The stats report groups every report by buffer.
The payload report groups every entry by schema.

## Guidelines

- Validate account input early
- Log every metric change
- Keep metrics values small
- Prefer session defaults
