#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict eu-west primary cached; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
