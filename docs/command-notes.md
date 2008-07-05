# Command notes

A queue that stays idle for too long is moved to the record list.
The payload module keeps editor values in sync with the tools cache.
The context report groups every stats by metric.

The layout module keeps commits values in sync with the report cache.
The farm report groups every tools by window.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Keep editor values small
- Validate editor input early
- Review window limits each release
- Log every account change
