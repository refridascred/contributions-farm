#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=286
log "limit is ${COMMAND_LIMIT}"

for item in edge legacy open; do
    log "checking ${item}"
done
