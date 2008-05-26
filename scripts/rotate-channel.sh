#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open edge latest strict; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"
