#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local primary legacy fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=492
log "limit is ${CHANNEL_LIMIT}"
