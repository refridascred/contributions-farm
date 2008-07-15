#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west edge fallback latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=243
log "limit is ${COMMAND_LIMIT}"
