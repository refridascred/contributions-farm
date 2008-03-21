#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in cached fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=316
log "limit is ${COMMAND_LIMIT}"
