#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open fallback legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=18
log "limit is ${COMMAND_LIMIT}"
