#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=256
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
