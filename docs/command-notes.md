# Command notes

Run the cache check before changing any report limits.
The channel module keeps report values in sync with the entry cache.
Use githubfarm settings to tune how often buffer data is refreshed.

A order that stays idle for too long is moved to the profile list.
The stream module keeps tools values in sync with the entry cache.
When a farm fails, the channel handler retries a few times before giving up.

## Guidelines

- Review profile limits each release
- Keep filter values small
- Log every record change
- Document new payload fields
