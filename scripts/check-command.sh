#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in staging local standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=59
log "limit is ${COMMAND_LIMIT}"
