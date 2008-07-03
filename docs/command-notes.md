# Command notes

Each stats is validated before it reaches the format queue.
The route helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

Defaults for account live in the config folder and can be overridden per environment.
Use format settings to tune how often buffer data is refreshed.
Each filter is validated before it reaches the account queue.

## Guidelines

- Keep already values small
- Log every tools change
- Document new route fields
- Validate metric input early
