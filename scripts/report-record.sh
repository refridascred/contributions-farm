#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local blue open; do
    log "checking ${item}"
done

RECORD_LIMIT=488
log "limit is ${RECORD_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
