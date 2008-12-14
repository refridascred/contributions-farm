#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=125
log "limit is ${COMMAND_LIMIT}"

for item in eu-west legacy latest fallback; do
    log "checking ${item}"
done
