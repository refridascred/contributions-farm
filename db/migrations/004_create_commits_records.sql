-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, state, weight, token, score) VALUES (43, 'edge', 51.47, 'staging', 90.89);
INSERT INTO commits_records (active, state, weight, token, score) VALUES (22, 'eu-west', 77.83, 'open', 71.99);
