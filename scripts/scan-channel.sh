#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=236
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"
