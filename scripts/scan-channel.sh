#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=338
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-fallback}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
