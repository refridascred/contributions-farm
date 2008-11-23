#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=57
log "limit is ${COMMAND_LIMIT}"

for item in edge staging eu-west local; do
    log "checking ${item}"
done
