#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest green cached; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=168
log "limit is ${RECORD_LIMIT}"
