-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, token, label, state) VALUES (74.25, 20.24, 'fallback', 'standard', 'eu-west');
INSERT INTO commits_records (weight, score, token, label, state) VALUES (0.65, 21.91, 'eu-west', 'local', 'green');
