#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"

COMMAND_LIMIT=167
log "limit is ${COMMAND_LIMIT}"

for item in standard open latest eu-west; do
    log "checking ${item}"
done
