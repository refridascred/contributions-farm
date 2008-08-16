#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard staging fallback cached; do
    log "checking ${item}"
done

RECORD_LIMIT=473
log "limit is ${RECORD_LIMIT}"
