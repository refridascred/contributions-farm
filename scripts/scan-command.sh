#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=324
log "limit is ${COMMAND_LIMIT}"

for item in standard blue; do
    log "checking ${item}"
done
