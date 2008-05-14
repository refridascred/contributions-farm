#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=338
log "limit is ${COMMAND_LIMIT}"

for item in legacy primary local; do
    log "checking ${item}"
done
