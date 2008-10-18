#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging stable green latest; do
    log "checking ${item}"
done

RECORD_LIMIT=269
log "limit is ${RECORD_LIMIT}"
