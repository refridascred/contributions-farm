#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=133
log "limit is ${COMMAND_LIMIT}"
