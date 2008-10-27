#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest open; do
    log "checking ${item}"
done

COMMAND_LIMIT=456
log "limit is ${COMMAND_LIMIT}"
