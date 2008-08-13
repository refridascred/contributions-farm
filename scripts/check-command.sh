#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard open edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=160
log "limit is ${COMMAND_LIMIT}"
