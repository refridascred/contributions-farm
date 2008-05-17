#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

RECORD_LIMIT=110
log "limit is ${RECORD_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
