#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=453
log "limit is ${COMMAND_LIMIT}"

for item in legacy stable; do
    log "checking ${item}"
done
