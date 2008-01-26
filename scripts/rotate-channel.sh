#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard stable; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
