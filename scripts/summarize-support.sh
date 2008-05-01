#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open legacy; do
    log "checking ${item}"
done

SUPPORT_LIMIT=23
log "limit is ${SUPPORT_LIMIT}"
