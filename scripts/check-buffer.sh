#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest staging edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
