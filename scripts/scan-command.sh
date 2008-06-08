#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=367
log "limit is ${COMMAND_LIMIT}"
