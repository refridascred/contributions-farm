#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback primary cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=388
log "limit is ${COMMAND_LIMIT}"
