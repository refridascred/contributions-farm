#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=263
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
