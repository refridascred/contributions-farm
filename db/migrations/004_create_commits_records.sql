-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, rank, state, score) VALUES ('primary', 69, 'blue', 66.2);
INSERT INTO commits_records (token, rank, state, score) VALUES ('eu-west', 56, 'fallback', 32.49);
