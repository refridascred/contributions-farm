#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=451
log "limit is ${COMMAND_LIMIT}"

for item in strict legacy fallback primary; do
    log "checking ${item}"
done
