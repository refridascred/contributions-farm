#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=394
log "limit is ${CHANNEL_LIMIT}"

for item in staging fallback green primary; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
