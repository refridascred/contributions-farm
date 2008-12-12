# Editor notes

Use githubfarm settings to tune how often entry data is refreshed.
The buffer helpers are pure functions, so they are safe to call from any thread.
The profile report groups every batch by booking.

Each githubfarm is validated before it reaches the context queue.
The context module keeps entry values in sync with the metric cache.

## Guidelines

- Document new context fields
- Validate stream input early
- Keep cluster values small
