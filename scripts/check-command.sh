#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=386
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback staging edge; do
    log "checking ${item}"
done
