#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=223
log "limit is ${COMMAND_LIMIT}"

for item in latest edge blue cached; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
