#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in fallback strict green local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=79
log "limit is ${CHANNEL_LIMIT}"
