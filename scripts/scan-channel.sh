#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=491
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"
