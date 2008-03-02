#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=204
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"
