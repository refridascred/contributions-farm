#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=347
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback cached local standard; do
    log "checking ${item}"
done
