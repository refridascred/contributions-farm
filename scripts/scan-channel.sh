#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
