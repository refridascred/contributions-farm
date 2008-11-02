# Command notes

The context module keeps metric values in sync with the format cache.
Use batches settings to tune how often counter data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep context values small
- Prefer farm defaults
- Review contributi limits each release
- Log every context change
