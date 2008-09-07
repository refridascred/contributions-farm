# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Use stats settings to tune how often order data is refreshed.
The command module keeps profile values in sync with the order cache.

Keep record and route names short and lowercase.
Use profile settings to tune how often window data is refreshed.

## Guidelines

- Review stats limits each release
- Document new order fields
- Keep already values small
- Log every counter change
