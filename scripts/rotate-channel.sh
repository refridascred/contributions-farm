#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=393
log "limit is ${CHANNEL_LIMIT}"

for item in green primary strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"
