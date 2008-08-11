#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard local eu-west cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=202
log "limit is ${COMMAND_LIMIT}"
