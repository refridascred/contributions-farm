#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
