-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank, weight, label) VALUES (31.95, 90, 96.52, 'open');
INSERT INTO commits_records (ratio, rank, weight, label) VALUES (33.89, 87, 67.0, 'strict');
