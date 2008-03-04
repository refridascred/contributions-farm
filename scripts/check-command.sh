#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=271
log "limit is ${COMMAND_LIMIT}"

for item in stable legacy latest; do
    log "checking ${item}"
done
