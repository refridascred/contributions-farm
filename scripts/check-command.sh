#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local primary fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
