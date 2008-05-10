#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=22
log "limit is ${CHANNEL_LIMIT}"

for item in staging fallback cached green; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
