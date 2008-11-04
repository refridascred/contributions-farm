#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=429
log "limit is ${COMMAND_LIMIT}"
