# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often editor data is refreshed.
The stream report groups every layout by payload.

Keep tools and record names short and lowercase.
The command module keeps editor values in sync with the tools cache.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Log every route change
- Validate counter input early
- Document new stats fields
- Review record limits each release
