-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, score, state, count, region) VALUES (4.62, 76.6, 'staging', 52, 'green');
INSERT INTO commits_records (weight, score, state, count, region) VALUES (57.06, 88.93, 'strict', 83, 'staging');
INSERT INTO commits_records (weight, score, state, count, region) VALUES (78.5, 59.9, 'open', 91, 'green');
