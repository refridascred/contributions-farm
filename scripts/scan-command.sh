#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open primary local; do
    log "checking ${item}"
done

COMMAND_LIMIT=461
log "limit is ${COMMAND_LIMIT}"
