-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, weight, active) VALUES (1, 6.62, 13);
INSERT INTO commits_records (count, weight, active) VALUES (99, 50.4, 96);
INSERT INTO commits_records (count, weight, active) VALUES (47, 40.61, 11);
