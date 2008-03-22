#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in open legacy fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=237
log "limit is ${COMMAND_LIMIT}"
