#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=115
log "limit is ${COMMAND_LIMIT}"
