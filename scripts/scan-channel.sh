#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=212
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    legacy)
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
