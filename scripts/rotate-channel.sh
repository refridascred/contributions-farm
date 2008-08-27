#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
