#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=287
log "limit is ${CHANNEL_LIMIT}"

for item in staging edge primary eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
