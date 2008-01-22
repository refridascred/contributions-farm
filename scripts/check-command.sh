#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open standard legacy latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=91
log "limit is ${COMMAND_LIMIT}"
