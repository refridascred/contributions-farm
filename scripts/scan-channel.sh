#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
