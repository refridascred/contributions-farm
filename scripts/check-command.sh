#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"

COMMAND_LIMIT=344
log "limit is ${COMMAND_LIMIT}"

for item in blue green eu-west fallback; do
    log "checking ${item}"
done
