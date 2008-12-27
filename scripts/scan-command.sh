#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green edge staging fallback; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=359
log "limit is ${COMMAND_LIMIT}"
