-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, weight, active, score) VALUES ('open', 49.82, 77, 45.3);
INSERT INTO commits_records (state, weight, active, score) VALUES ('green', 5.64, 25, 72.01);
INSERT INTO commits_records (state, weight, active, score) VALUES ('local', 63.11, 24, 43.51);
