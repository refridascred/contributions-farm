#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback standard staging eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=202
log "limit is ${COMMAND_LIMIT}"
