-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, rank, state, owner) VALUES (40.32, 27.2, 24, 'standard', 'legacy');
INSERT INTO commits_records (ratio, score, rank, state, owner) VALUES (75.51, 20.02, 15, 'green', 'green');
INSERT INTO commits_records (ratio, score, rank, state, owner) VALUES (0.29, 84.18, 72, 'strict', 'standard');
