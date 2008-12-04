#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=137
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging eu-west; do
    log "checking ${item}"
done
