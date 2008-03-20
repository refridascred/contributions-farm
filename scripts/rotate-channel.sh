#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
