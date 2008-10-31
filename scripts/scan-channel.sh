#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green staging standard; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=491
log "limit is ${CHANNEL_LIMIT}"
