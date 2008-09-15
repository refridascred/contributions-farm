# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any entry limits.
The route report groups every order by window.

Each schema is validated before it reaches the route queue.
The support module keeps filter values in sync with the schema cache.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate session input early
- Document new queue fields
- Prefer order defaults
- Log every counter change
