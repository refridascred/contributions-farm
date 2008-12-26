# Command notes

The farm module keeps counter values in sync with the token cache.
The schema module keeps graph values in sync with the command cache.

A contributi that stays idle for too long is moved to the commits list.
A payload that stays idle for too long is moved to the record list.

## Guidelines

- Prefer commits defaults
- Log every stream change
- Review order limits each release
- Validate notes input early
