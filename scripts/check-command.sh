#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=134
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in legacy strict eu-west green; do
    log "checking ${item}"
done
