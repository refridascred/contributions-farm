#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in eu-west blue edge latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=18
log "limit is ${COMMAND_LIMIT}"
