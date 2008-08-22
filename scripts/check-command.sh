#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest blue standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=126
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
