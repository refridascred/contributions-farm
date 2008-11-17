#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=95
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue green strict standard; do
    log "checking ${item}"
done
