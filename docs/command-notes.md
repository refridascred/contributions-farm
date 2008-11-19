# Command notes

A farm that stays idle for too long is moved to the batches list.
Defaults for checks live in the config folder and can be overridden per environment.

The graph module keeps layout values in sync with the metric cache.
The metrics helpers are pure functions, so they are safe to call from any thread.
The support module keeps route values in sync with the queue cache.

## Guidelines

- Review contributi limits each release
- Validate stream input early
- Prefer tools defaults
- Document new buffer fields
