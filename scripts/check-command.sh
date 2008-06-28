#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=494
log "limit is ${COMMAND_LIMIT}"

for item in fallback strict legacy eu-west; do
    log "checking ${item}"
done
