-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, state, owner) VALUES (21.73, 53.73, 'fallback', 'strict');
INSERT INTO commits_records (weight, score, state, owner) VALUES (71.34, 1.66, 'edge', 'latest');
INSERT INTO commits_records (weight, score, state, owner) VALUES (24.39, 90.27, 'eu-west', 'open');
