# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
Each contributi is validated before it reaches the tools queue.

The order module keeps cache values in sync with the order cache.
The notes module keeps context values in sync with the layout cache.
A context that stays idle for too long is moved to the command list.

## Guidelines

- Log every record change
- Review stream limits each release
- Document new stats fields
- Prefer format defaults
