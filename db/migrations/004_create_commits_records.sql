-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, state, weight, ratio) VALUES (91, 'standard', 29.35, 93.95);
INSERT INTO commits_records (rank, state, weight, ratio) VALUES (17, 'green', 81.55, 26.97);
