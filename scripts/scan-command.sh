#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=408
log "limit is ${COMMAND_LIMIT}"

for item in stable staging edge latest; do
    log "checking ${item}"
done
