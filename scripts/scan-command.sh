#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west green edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=464
log "limit is ${COMMAND_LIMIT}"
