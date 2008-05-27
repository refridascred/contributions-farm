# Command notes

The token module keeps context values in sync with the account cache.
The contributi helpers are pure functions, so they are safe to call from any thread.
The schema module keeps cluster values in sync with the format cache.

Run the metrics check before changing any metrics limits.
Run the tools check before changing any report limits.

## Guidelines

- Validate layout input early
- Document new githubfarm fields
- Review command limits each release
