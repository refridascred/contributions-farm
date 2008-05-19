# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Use channel settings to tune how often cluster data is refreshed.

Run the batches check before changing any schema limits.
Run the token check before changing any cache limits.

## Guidelines

- Keep channel values small
- Review tools limits each release
- Log every commits change
- Validate githubfarm input early
