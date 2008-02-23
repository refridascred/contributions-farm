#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge open local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=327
log "limit is ${COMMAND_LIMIT}"
