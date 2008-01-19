# Command notes

A token that stays idle for too long is moved to the layout list.
Defaults for entry live in the config folder and can be overridden per environment.

The order module keeps schema values in sync with the queue cache.
Defaults for graph live in the config folder and can be overridden per environment.
The payload module keeps format values in sync with the commits cache.

## Guidelines

- Review buffer limits each release
- Document new schema fields
- Keep filter values small
