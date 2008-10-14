#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=192
log "limit is ${COMMAND_LIMIT}"

for item in legacy standard cached; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"
