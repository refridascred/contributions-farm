-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, score, weight, state, token) VALUES (78, 3.65, 66.78, 'legacy', 'eu-west');
INSERT INTO commits_records (active, score, weight, state, token) VALUES (9, 52.62, 75.34, 'open', 'legacy');
