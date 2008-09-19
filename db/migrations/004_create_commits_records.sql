-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, weight, rank, label, score) VALUES ('staging', 63.8, 90, 'latest', 5.46);
INSERT INTO commits_records (state, weight, rank, label, score) VALUES ('local', 46.36, 36, 'standard', 43.28);
