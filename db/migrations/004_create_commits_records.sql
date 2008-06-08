-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, weight) VALUES (37, 'open', 29.61);
INSERT INTO commits_records (count, owner, weight) VALUES (8, 'primary', 16.89);
