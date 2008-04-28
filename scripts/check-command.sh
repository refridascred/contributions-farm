#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=347
log "limit is ${COMMAND_LIMIT}"
