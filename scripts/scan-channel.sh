#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict fallback legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
