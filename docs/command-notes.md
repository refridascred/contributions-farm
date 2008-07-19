# Command notes

The payload report groups every cluster by batch.
A layout that stays idle for too long is moved to the counter list.
The format report groups every filter by channel.

When a entry fails, the format handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Log every record change
- Review schema limits each release
- Prefer format defaults
- Document new graph fields
