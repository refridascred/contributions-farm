#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=404
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"
