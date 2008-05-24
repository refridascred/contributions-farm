#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=233
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in standard primary open staging; do
    log "checking ${item}"
done
