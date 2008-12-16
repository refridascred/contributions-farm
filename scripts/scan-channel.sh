#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=343
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
