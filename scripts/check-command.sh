#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local blue stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=85
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
