#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=66
log "limit is ${COMMAND_LIMIT}"

for item in staging eu-west cached blue; do
    log "checking ${item}"
done
