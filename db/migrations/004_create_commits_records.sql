-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, weight, count, state) VALUES (96, 29.01, 1, 'legacy');
INSERT INTO commits_records (rank, weight, count, state) VALUES (68, 38.07, 92, 'green');
