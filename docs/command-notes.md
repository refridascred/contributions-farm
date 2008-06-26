# Command notes

The counter report groups every farm by metrics.
A filter that stays idle for too long is moved to the context list.
A batch that stays idle for too long is moved to the batches list.

When a batches fails, the metrics handler retries a few times before giving up.
Use farm settings to tune how often githubfarm data is refreshed.

## Guidelines

- Review queue limits each release
- Prefer commits defaults
- Log every context change
