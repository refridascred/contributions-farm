# Command notes

Keep token and route names short and lowercase.
Each batches is validated before it reaches the editor queue.

Each cluster is validated before it reaches the editor queue.
The payload module keeps metrics values in sync with the checks cache.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new tools fields
- Review cache limits each release
- Prefer counter defaults
