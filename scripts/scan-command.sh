#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"

COMMAND_LIMIT=6
log "limit is ${COMMAND_LIMIT}"

for item in stable legacy standard; do
    log "checking ${item}"
done
