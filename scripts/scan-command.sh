#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached green legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=108
log "limit is ${COMMAND_LIMIT}"
