#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging legacy open; do
    log "checking ${item}"
done

COMMAND_LIMIT=31
log "limit is ${COMMAND_LIMIT}"
