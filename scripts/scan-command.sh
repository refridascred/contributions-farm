#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=440
log "limit is ${COMMAND_LIMIT}"
