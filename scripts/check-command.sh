#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=333
log "limit is ${COMMAND_LIMIT}"

for item in stable local green; do
    log "checking ${item}"
done
