#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=167
log "limit is ${CHANNEL_LIMIT}"

for item in primary cached staging edge; do
    log "checking ${item}"
done
