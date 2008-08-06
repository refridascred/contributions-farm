-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, label, owner, score) VALUES ('open', 'fallback', 'latest', 85.56);
INSERT INTO stats_logs (state, label, owner, score) VALUES ('staging', 'blue', 'legacy', 20.46);
INSERT INTO stats_logs (state, label, owner, score) VALUES ('blue', 'open', 'primary', 21.14);
