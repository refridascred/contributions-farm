#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=126
log "limit is ${COMMAND_LIMIT}"

for item in open latest; do
    log "checking ${item}"
done
