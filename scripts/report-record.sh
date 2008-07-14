#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local stable open latest; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=273
log "limit is ${RECORD_LIMIT}"
