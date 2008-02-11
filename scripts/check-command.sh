#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=184
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"
