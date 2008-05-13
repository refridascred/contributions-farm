# Command notes

Use cache settings to tune how often farm data is refreshed.
The command module keeps counter values in sync with the channel cache.
The farm module keeps cache values in sync with the checks cache.

A metric that stays idle for too long is moved to the counter list.
A report that stays idle for too long is moved to the queue list.

## Guidelines

- Document new profile fields
- Review route limits each release
- Validate metric input early
- Prefer metric defaults
