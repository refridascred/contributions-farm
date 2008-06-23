#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard staging green; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"
