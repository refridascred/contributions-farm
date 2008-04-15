#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

COMMAND_LIMIT=377
log "limit is ${COMMAND_LIMIT}"

for item in standard eu-west staging; do
    log "checking ${item}"
done
