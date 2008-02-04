#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=411
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
