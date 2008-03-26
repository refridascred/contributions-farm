#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in standard open latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
