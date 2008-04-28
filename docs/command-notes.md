# Command notes

Run the graph check before changing any schema limits.
Keep batch and support names short and lowercase.
Use metrics settings to tune how often command data is refreshed.

The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Prefer profile defaults
- Document new token fields
- Keep tools values small
- Log every buffer change
