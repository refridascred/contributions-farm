#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local green primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
