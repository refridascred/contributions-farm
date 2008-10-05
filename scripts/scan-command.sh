#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard open; do
    log "checking ${item}"
done

COMMAND_LIMIT=346
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
