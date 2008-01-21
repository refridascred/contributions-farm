# Command notes

Each window is validated before it reaches the route queue.
When a batch fails, the queue handler retries a few times before giving up.
Use report settings to tune how often editor data is refreshed.

The report module keeps metrics values in sync with the layout cache.
A notes that stays idle for too long is moved to the account list.

## Guidelines

- Log every route change
- Review stream limits each release
- Keep record values small
- Validate filter input early
