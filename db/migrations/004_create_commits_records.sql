-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, state, score, ratio) VALUES (5.66, 'strict', 61.8, 91.64);
INSERT INTO commits_records (weight, state, score, ratio) VALUES (65.88, 'standard', 62.34, 24.08);
INSERT INTO commits_records (weight, state, score, ratio) VALUES (8.12, 'eu-west', 81.0, 57.94);
