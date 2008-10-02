#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback strict latest; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=153
log "limit is ${COMMAND_LIMIT}"
