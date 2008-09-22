#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open green standard fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
