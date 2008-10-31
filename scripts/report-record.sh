#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=469
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
