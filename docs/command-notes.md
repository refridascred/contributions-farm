# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often metric data is refreshed.
Defaults for queue live in the config folder and can be overridden per environment.

A metric that stays idle for too long is moved to the account list.
The layout report groups every batches by layout.
The batches report groups every already by account.

## Guidelines

- Document new notes fields
- Validate already input early
- Keep token values small
