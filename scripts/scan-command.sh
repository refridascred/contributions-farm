#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary green latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=65
log "limit is ${COMMAND_LIMIT}"
