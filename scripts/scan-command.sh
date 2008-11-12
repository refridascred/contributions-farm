#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=123
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in primary green; do
    log "checking ${item}"
done
