#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

CHANNEL_LIMIT=425
log "limit is ${CHANNEL_LIMIT}"

for item in standard edge; do
    log "checking ${item}"
done
