#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=300
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
