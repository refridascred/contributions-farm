#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=289
log "limit is ${COMMAND_LIMIT}"
