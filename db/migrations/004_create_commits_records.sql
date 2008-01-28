-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, weight, state) VALUES ('stable', 98, 38.58, 'legacy');
INSERT INTO commits_records (token, rank, weight, state) VALUES ('staging', 96, 96.82, 'legacy');
