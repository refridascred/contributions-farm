#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in open legacy stable strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=12
log "limit is ${COMMAND_LIMIT}"
