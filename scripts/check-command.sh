#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open; do
    log "checking ${item}"
done

COMMAND_LIMIT=140
log "limit is ${COMMAND_LIMIT}"
