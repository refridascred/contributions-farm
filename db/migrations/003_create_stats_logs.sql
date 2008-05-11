-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, score, label, level, rank) VALUES ('latest', 98.65, 'staging', 35, 77);
INSERT INTO stats_logs (state, score, label, level, rank) VALUES ('blue', 49.75, 'stable', 72, 71);
INSERT INTO stats_logs (state, score, label, level, rank) VALUES ('primary', 75.77, 'green', 58, 74);
