#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable local; do
    log "checking ${item}"
done

COMMAND_LIMIT=117
log "limit is ${COMMAND_LIMIT}"
