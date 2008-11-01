#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging blue fallback; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=306
log "limit is ${COMMAND_LIMIT}"
