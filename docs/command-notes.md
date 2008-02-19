# Command notes

The payload module keeps metrics values in sync with the commits cache.
Use channel settings to tune how often payload data is refreshed.
The editor module keeps cluster values in sync with the commits cache.

The account report groups every buffer by cluster.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep graph values small
- Log every queue change
- Prefer graph defaults
