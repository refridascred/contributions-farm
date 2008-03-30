#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue staging edge; do
    log "checking ${item}"
done

RECORD_LIMIT=488
log "limit is ${RECORD_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
