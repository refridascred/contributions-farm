-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, owner, weight, label) VALUES ('blue', 'standard', 1.85, 'latest');
INSERT INTO stats_logs (state, owner, weight, label) VALUES ('eu-west', 'blue', 36.96, 'fallback');
