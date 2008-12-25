#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=122
log "limit is ${SUPPORT_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
