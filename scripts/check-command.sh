#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest green edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=323
log "limit is ${COMMAND_LIMIT}"
