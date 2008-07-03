#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=348
log "limit is ${CHANNEL_LIMIT}"

for item in primary standard blue; do
    log "checking ${item}"
done
