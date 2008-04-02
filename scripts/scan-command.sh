#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west strict latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=308
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"
