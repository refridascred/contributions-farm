#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=372
log "limit is ${RECORD_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open blue strict cached; do
    log "checking ${item}"
done
