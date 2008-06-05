#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=216
log "limit is ${COMMAND_LIMIT}"
