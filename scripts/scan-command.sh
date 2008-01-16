#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=123
log "limit is ${COMMAND_LIMIT}"

for item in legacy latest local open; do
    log "checking ${item}"
done
