#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in legacy standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=329
log "limit is ${COMMAND_LIMIT}"
