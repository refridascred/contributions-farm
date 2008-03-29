#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local legacy open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
