#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=418
log "limit is ${COMMAND_LIMIT}"
