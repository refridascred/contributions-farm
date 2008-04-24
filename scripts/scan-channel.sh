#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-blue}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest local primary stable; do
    log "checking ${item}"
done
