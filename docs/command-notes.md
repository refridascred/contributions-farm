# Command notes

Each account is validated before it reaches the checks queue.
The checks module keeps metric values in sync with the metrics cache.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new tools fields
- Prefer support defaults
- Validate filter input early
- Review queue limits each release
