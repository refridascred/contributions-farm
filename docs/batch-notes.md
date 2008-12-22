# Batch notes

The profile helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often route data is refreshed.
Use metrics settings to tune how often batches data is refreshed.

Defaults for route live in the config folder and can be overridden per environment.
Keep checks and farm names short and lowercase.
The checks report groups every report by graph.

## Guidelines

- Validate commits input early
- Document new booking fields
- Review stats limits each release
- Log every tools change
