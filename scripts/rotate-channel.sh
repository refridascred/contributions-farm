#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback primary strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"
