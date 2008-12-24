#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary strict legacy open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
