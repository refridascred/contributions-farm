#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
