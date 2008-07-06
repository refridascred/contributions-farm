#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=111
log "limit is ${CHANNEL_LIMIT}"

for item in fallback strict; do
    log "checking ${item}"
done
