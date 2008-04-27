#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable fallback local; do
    log "checking ${item}"
done

COMMAND_LIMIT=411
log "limit is ${COMMAND_LIMIT}"
