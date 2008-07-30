-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, weight, active) VALUES (74.43, 48.66, 48);
INSERT INTO commits_records (ratio, weight, active) VALUES (32.81, 27.71, 9);
