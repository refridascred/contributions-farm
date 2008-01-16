#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=166
log "limit is ${CHANNEL_LIMIT}"

for item in primary strict; do
    log "checking ${item}"
done
