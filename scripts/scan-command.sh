#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=5
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local standard; do
    log "checking ${item}"
done
