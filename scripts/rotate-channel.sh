#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-blue}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
