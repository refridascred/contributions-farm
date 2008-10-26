#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=292
log "limit is ${CHANNEL_LIMIT}"

for item in fallback local green edge; do
    log "checking ${item}"
done
