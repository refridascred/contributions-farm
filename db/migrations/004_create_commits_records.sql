-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, weight, label) VALUES (19.4, 2, 47.29, 'open');
INSERT INTO commits_records (ratio, count, weight, label) VALUES (96.25, 64, 47.44, 'cached');
