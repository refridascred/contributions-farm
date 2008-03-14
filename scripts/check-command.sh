#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local cached eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=223
log "limit is ${COMMAND_LIMIT}"
