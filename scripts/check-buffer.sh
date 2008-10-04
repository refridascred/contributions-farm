#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
