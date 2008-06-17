#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=157
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
