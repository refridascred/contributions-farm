-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, score, level, weight, owner) VALUES ('local', 89.82, 97, 30.85, 'primary');
INSERT INTO stats_logs (state, score, level, weight, owner) VALUES ('open', 74.61, 49, 81.84, 'open');
INSERT INTO stats_logs (state, score, level, weight, owner) VALUES ('blue', 46.16, 56, 74.79, 'open');
