#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-blue}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
