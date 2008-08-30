# Command notes

The queue report groups every batch by cache.
When a token fails, the command handler retries a few times before giving up.
The editor module keeps token values in sync with the filter cache.

## Guidelines

- Keep support values small
- Review batch limits each release
- Log every order change
