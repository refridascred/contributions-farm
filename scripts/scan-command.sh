#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local edge cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=294
log "limit is ${COMMAND_LIMIT}"
