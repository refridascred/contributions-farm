#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=480
log "limit is ${COMMAND_LIMIT}"

for item in staging eu-west latest; do
    log "checking ${item}"
done
