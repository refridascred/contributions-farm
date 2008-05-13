#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable standard legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=179
log "limit is ${COMMAND_LIMIT}"
