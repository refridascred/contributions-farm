#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in stable local latest eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"
