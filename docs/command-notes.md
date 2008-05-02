# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
Use record settings to tune how often counter data is refreshed.
A format that stays idle for too long is moved to the batches list.

The context report groups every record by record.
A record that stays idle for too long is moved to the stream list.

## Guidelines

- Keep window values small
- Prefer filter defaults
- Log every account change
