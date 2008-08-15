-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, label, ratio) VALUES (38, 'standard', 33.89);
INSERT INTO commits_records (rank, label, ratio) VALUES (82, 'blue', 64.75);
