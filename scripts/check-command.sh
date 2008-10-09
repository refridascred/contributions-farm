#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=49
log "limit is ${COMMAND_LIMIT}"

for item in strict primary eu-west latest; do
    log "checking ${item}"
done
