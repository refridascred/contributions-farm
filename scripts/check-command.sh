#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached local; do
    log "checking ${item}"
done

COMMAND_LIMIT=257
log "limit is ${COMMAND_LIMIT}"
