#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary local; do
    log "checking ${item}"
done

COMMAND_LIMIT=374
log "limit is ${COMMAND_LIMIT}"
