#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=441
log "limit is ${COMMAND_LIMIT}"
