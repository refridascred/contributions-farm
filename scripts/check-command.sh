#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

COMMAND_LIMIT=155
log "limit is ${COMMAND_LIMIT}"

for item in cached stable primary; do
    log "checking ${item}"
done
