#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=139
log "limit is ${COMMAND_LIMIT}"

for item in edge standard staging; do
    log "checking ${item}"
done
