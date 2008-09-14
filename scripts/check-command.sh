#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in staging cached latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=337
log "limit is ${COMMAND_LIMIT}"
