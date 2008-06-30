# Command notes

When a channel fails, the metric handler retries a few times before giving up.
Keep layout and order names short and lowercase.

A batch that stays idle for too long is moved to the stats list.
Use report settings to tune how often already data is refreshed.
When a layout fails, the profile handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Review report limits each release
- Validate metric input early
- Document new support fields
