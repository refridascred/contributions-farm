#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=14
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
