#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"

COMMAND_LIMIT=59
log "limit is ${COMMAND_LIMIT}"

for item in legacy eu-west; do
    log "checking ${item}"
done
