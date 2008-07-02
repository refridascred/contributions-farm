#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west cached edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=35
log "limit is ${COMMAND_LIMIT}"
