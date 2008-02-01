#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in legacy edge eu-west open; do
    log "checking ${item}"
done

COMMAND_LIMIT=418
log "limit is ${COMMAND_LIMIT}"
