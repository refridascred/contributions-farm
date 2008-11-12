#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=404
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest standard; do
    log "checking ${item}"
done
