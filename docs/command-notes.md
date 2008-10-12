# Command notes

A editor that stays idle for too long is moved to the payload list.
The command module keeps entry values in sync with the contributi cache.

When a stats fails, the profile handler retries a few times before giving up.
A entry that stays idle for too long is moved to the profile list.
Each checks is validated before it reaches the filter queue.

## Guidelines

- Review profile limits each release
- Document new stats fields
- Validate entry input early
