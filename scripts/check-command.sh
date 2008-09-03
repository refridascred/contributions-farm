#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue green strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=44
log "limit is ${COMMAND_LIMIT}"
