-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, weight, state, level) VALUES (52, 70.52, 'legacy', 54);
INSERT INTO commits_records (rank, weight, state, level) VALUES (75, 45.69, 'edge', 70);
INSERT INTO commits_records (rank, weight, state, level) VALUES (80, 31.09, 'edge', 50);
