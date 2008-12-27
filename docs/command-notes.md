# Command notes

Use stream settings to tune how often metrics data is refreshed.
A batch that stays idle for too long is moved to the command list.

A schema that stays idle for too long is moved to the order list.
The format module keeps githubfarm values in sync with the stream cache.
Use farm settings to tune how often order data is refreshed.

## Guidelines

- Log every route change
- Validate queue input early
- Review context limits each release
