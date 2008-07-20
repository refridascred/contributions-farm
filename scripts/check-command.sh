#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west stable strict legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"

COMMAND_LIMIT=418
log "limit is ${COMMAND_LIMIT}"
