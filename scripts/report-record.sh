#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging stable; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"
