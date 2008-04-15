#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy open eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=124
log "limit is ${COMMAND_LIMIT}"
