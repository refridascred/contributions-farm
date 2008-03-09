# Command notes

The channel module keeps metrics values in sync with the order cache.
The payload report groups every counter by cache.
A cache that stays idle for too long is moved to the report list.

## Guidelines

- Review githubfarm limits each release
- Keep order values small
- Document new account fields
- Log every githubfarm change
