#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=244
log "limit is ${COMMAND_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
