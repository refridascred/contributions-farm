-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, rank, weight) VALUES ('strict', 'open', 10, 2.05);
INSERT INTO commits_records (token, state, rank, weight) VALUES ('green', 'standard', 31, 44.78);
INSERT INTO commits_records (token, state, rank, weight) VALUES ('blue', 'edge', 19, 80.27);
