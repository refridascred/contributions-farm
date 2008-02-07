#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=186
log "limit is ${COMMAND_LIMIT}"

for item in open staging strict primary; do
    log "checking ${item}"
done
