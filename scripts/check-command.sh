#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=92
log "limit is ${COMMAND_LIMIT}"

for item in fallback local; do
    log "checking ${item}"
done
