#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=467
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in edge standard staging strict; do
    log "checking ${item}"
done
