-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, label, region, rank, state) VALUES (0, 'staging', 'primary', 23, 'blue');
INSERT INTO stats_logs (level, label, region, rank, state) VALUES (45, 'local', 'eu-west', 88, 'strict');
INSERT INTO stats_logs (level, label, region, rank, state) VALUES (94, 'fallback', 'local', 62, 'eu-west');
