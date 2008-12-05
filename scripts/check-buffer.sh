#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary open blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
