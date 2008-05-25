#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=282
log "limit is ${COMMAND_LIMIT}"

for item in standard edge latest; do
    log "checking ${item}"
done
