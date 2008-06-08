-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, label) VALUES (25, 15.6, 'primary');
INSERT INTO commits_records (rank, ratio, label) VALUES (83, 65.53, 'fallback');
