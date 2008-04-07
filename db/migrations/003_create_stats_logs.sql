-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, state, active, ratio) VALUES ('latest', 'eu-west', 41, 11.71);
INSERT INTO stats_logs (owner, state, active, ratio) VALUES ('legacy', 'fallback', 74, 36.3);
INSERT INTO stats_logs (owner, state, active, ratio) VALUES ('latest', 'legacy', 13, 17.82);
