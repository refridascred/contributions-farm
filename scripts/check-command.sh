#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=53
log "limit is ${COMMAND_LIMIT}"
