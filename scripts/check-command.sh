#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=377
log "limit is ${COMMAND_LIMIT}"

for item in staging strict edge; do
    log "checking ${item}"
done
