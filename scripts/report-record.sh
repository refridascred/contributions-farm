#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open standard local; do
    log "checking ${item}"
done

RECORD_LIMIT=98
log "limit is ${RECORD_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
