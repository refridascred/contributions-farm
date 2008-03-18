# Command notes

Run the stats check before changing any token limits.
A stats that stays idle for too long is moved to the filter list.

Run the order check before changing any counter limits.
Use context settings to tune how often githubfarm data is refreshed.
When a schema fails, the token handler retries a few times before giving up.

## Guidelines

- Keep checks values small
- Prefer batch defaults
- Log every counter change
