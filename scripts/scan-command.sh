#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=162
log "limit is ${COMMAND_LIMIT}"
