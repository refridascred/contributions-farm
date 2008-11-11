#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict eu-west latest; do
    log "checking ${item}"
done

RECORD_LIMIT=355
log "limit is ${RECORD_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
