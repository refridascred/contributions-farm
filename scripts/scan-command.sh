#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary legacy staging fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=426
log "limit is ${COMMAND_LIMIT}"
