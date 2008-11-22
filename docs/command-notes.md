# Command notes

A token that stays idle for too long is moved to the order list.
Use window settings to tune how often entry data is refreshed.
Each already is validated before it reaches the command queue.

The checks helpers are pure functions, so they are safe to call from any thread.
The counter module keeps contributi values in sync with the account cache.

## Guidelines

- Prefer metrics defaults
- Keep metrics values small
- Validate contributi input early
