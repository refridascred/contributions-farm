#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=326
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"
