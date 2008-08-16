#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=47
log "limit is ${RECORD_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
