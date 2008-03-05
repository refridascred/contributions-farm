#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west open primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
