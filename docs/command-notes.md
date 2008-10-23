# Command notes

The metric module keeps schema values in sync with the order cache.
The notes report groups every already by window.
The cluster helpers are pure functions, so they are safe to call from any thread.

The profile module keeps filter values in sync with the format cache.
Use checks settings to tune how often notes data is refreshed.

## Guidelines

- Keep commits values small
- Document new command fields
- Validate account input early
