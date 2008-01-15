#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=230
log "limit is ${COMMAND_LIMIT}"

for item in edge primary latest cached; do
    log "checking ${item}"
done
