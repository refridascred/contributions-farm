-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, rank, score, owner, label) VALUES ('strict', 41, 43.01, 'staging', 'latest');
INSERT INTO commits_records (state, rank, score, owner, label) VALUES ('staging', 76, 98.67, 'edge', 'green');
INSERT INTO commits_records (state, rank, score, owner, label) VALUES ('standard', 24, 81.9, 'staging', 'staging');
