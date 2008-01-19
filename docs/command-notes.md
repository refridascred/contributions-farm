# Command notes

Use counter settings to tune how often order data is refreshed.
Defaults for checks live in the config folder and can be overridden per environment.
The report report groups every order by session.

When a order fails, the schema handler retries a few times before giving up.
When a editor fails, the channel handler retries a few times before giving up.

## Guidelines

- Document new already fields
- Keep counter values small
- Log every report change
- Prefer window defaults
