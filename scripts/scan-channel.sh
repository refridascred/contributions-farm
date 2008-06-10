#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=331
log "limit is ${CHANNEL_LIMIT}"

for item in fallback green; do
    log "checking ${item}"
done
