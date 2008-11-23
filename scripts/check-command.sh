#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=457
log "limit is ${COMMAND_LIMIT}"
