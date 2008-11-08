#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=259
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
