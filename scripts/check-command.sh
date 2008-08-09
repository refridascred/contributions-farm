#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest standard blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=154
log "limit is ${COMMAND_LIMIT}"
