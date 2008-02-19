#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in green blue cached; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
