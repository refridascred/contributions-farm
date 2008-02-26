# Command notes

The metrics module keeps stats values in sync with the batches cache.
A cluster that stays idle for too long is moved to the commits list.

The record module keeps cluster values in sync with the token cache.
The account report groups every record by cache.

## Guidelines

- Document new support fields
- Keep notes values small
- Log every order change
- Review token limits each release
