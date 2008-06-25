#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west standard local green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

COMMAND_LIMIT=18
log "limit is ${COMMAND_LIMIT}"
