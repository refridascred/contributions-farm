#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
