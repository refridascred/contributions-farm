#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback edge latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=382
log "limit is ${COMMAND_LIMIT}"
