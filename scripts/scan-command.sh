#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in primary strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=19
log "limit is ${COMMAND_LIMIT}"
