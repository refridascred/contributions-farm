-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, token, owner, ratio) VALUES ('cached', 'standard', 'stable', 74.31);
INSERT INTO stats_logs (state, token, owner, ratio) VALUES ('local', 'stable', 'stable', 43.21);
INSERT INTO stats_logs (state, token, owner, ratio) VALUES ('strict', 'eu-west', 'standard', 98.33);
