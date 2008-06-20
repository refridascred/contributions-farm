#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in standard staging primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=23
log "limit is ${COMMAND_LIMIT}"
