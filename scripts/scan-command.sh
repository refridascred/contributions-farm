#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=286
log "limit is ${COMMAND_LIMIT}"

for item in green edge open cached; do
    log "checking ${item}"
done
