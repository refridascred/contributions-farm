#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in primary fallback staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=434
log "limit is ${COMMAND_LIMIT}"
