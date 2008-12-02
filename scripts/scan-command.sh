#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=211
log "limit is ${COMMAND_LIMIT}"

for item in stable staging latest; do
    log "checking ${item}"
done
