#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"

for item in eu-west green; do
    log "checking ${item}"
done
