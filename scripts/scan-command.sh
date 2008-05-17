#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=162
log "limit is ${COMMAND_LIMIT}"

for item in edge green strict latest; do
    log "checking ${item}"
done
