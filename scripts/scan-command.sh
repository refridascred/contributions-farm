#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

COMMAND_LIMIT=470
log "limit is ${COMMAND_LIMIT}"
