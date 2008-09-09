# Command notes

The buffer module keeps farm values in sync with the order cache.
Keep command and command names short and lowercase.
The order report groups every entry by counter.

The commits module keeps already values in sync with the checks cache.
Each payload is validated before it reaches the cluster queue.

## Guidelines

- Review order limits each release
- Keep payload values small
- Log every stats change
- Document new payload fields
