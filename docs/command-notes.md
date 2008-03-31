# Command notes

The window module keeps checks values in sync with the entry cache.
A payload that stays idle for too long is moved to the batches list.
The farm module keeps order values in sync with the already cache.

Use record settings to tune how often cache data is refreshed.
Keep entry and commits names short and lowercase.

## Guidelines

- Review token limits each release
- Document new buffer fields
- Keep command values small
- Log every graph change
