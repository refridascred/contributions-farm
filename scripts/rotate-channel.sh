#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=161
log "limit is ${CHANNEL_LIMIT}"

for item in open fallback cached strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"
