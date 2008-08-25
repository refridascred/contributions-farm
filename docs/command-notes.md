# Command notes

When a already fails, the counter handler retries a few times before giving up.
Run the record check before changing any profile limits.
A profile that stays idle for too long is moved to the account list.

Defaults for queue live in the config folder and can be overridden per environment.
Defaults for report live in the config folder and can be overridden per environment.
The farm report groups every support by record.

## Guidelines

- Log every graph change
- Review schema limits each release
- Validate payload input early
- Keep token values small
