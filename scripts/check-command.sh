#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback standard edge strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=339
log "limit is ${COMMAND_LIMIT}"
