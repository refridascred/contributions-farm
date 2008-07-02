#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open green; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"
