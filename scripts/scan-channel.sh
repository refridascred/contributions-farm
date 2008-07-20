#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=34
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
