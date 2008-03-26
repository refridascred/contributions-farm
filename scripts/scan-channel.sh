#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green eu-west local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
