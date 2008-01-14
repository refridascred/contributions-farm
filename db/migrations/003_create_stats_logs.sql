-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, label, count, owner) VALUES ('legacy', 'strict', 15, 'legacy');
INSERT INTO stats_logs (state, label, count, owner) VALUES ('open', 'open', 52, 'primary');
INSERT INTO stats_logs (state, label, count, owner) VALUES ('green', 'open', 27, 'fallback');
