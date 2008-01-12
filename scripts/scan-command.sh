#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=205
log "limit is ${COMMAND_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
