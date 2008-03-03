#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west green standard fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=423
log "limit is ${COMMAND_LIMIT}"
