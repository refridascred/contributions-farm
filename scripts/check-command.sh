#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=208
log "limit is ${COMMAND_LIMIT}"

for item in primary open; do
    log "checking ${item}"
done
