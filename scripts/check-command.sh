#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable standard fallback latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=464
log "limit is ${COMMAND_LIMIT}"
