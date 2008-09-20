#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=229
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"
