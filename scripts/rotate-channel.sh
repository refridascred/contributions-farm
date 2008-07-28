#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=210
log "limit is ${CHANNEL_LIMIT}"

for item in fallback open legacy; do
    log "checking ${item}"
done
