#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=175
log "limit is ${CHANNEL_LIMIT}"

for item in open staging stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"
