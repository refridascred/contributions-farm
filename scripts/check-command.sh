#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

COMMAND_LIMIT=391
log "limit is ${COMMAND_LIMIT}"
