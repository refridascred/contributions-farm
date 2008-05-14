# Command notes

Run the support check before changing any stream limits.
Each account is validated before it reaches the schema queue.
Keep format and account names short and lowercase.

The editor module keeps window values in sync with the checks cache.
Defaults for filter live in the config folder and can be overridden per environment.
The cache module keeps metric values in sync with the account cache.

## Guidelines

- Document new account fields
- Validate contributi input early
- Review farm limits each release
- Log every payload change
