#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=42
log "limit is ${COMMAND_LIMIT}"
