-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, rank, state, weight) VALUES ('latest', 87, 'fallback', 69.12);
INSERT INTO commits_records (token, rank, state, weight) VALUES ('standard', 82, 'fallback', 30.65);
INSERT INTO commits_records (token, rank, state, weight) VALUES ('legacy', 21, 'primary', 38.33);
