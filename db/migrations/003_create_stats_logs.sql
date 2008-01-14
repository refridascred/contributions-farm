-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, state, count, ratio) VALUES ('stable', 'green', 38, 34.31);
INSERT INTO stats_logs (token, state, count, ratio) VALUES ('cached', 'strict', 60, 19.97);
INSERT INTO stats_logs (token, state, count, ratio) VALUES ('eu-west', 'local', 89, 98.44);
