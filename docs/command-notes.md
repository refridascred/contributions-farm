# Command notes

Use filter settings to tune how often order data is refreshed.
Run the stats check before changing any queue limits.
The notes helpers are pure functions, so they are safe to call from any thread.

Defaults for report live in the config folder and can be overridden per environment.
Keep notes and account names short and lowercase.

## Guidelines

- Validate counter input early
- Document new stream fields
- Review tools limits each release
- Log every metric change
