#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open cached latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=496
log "limit is ${COMMAND_LIMIT}"
