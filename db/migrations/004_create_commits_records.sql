-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, ratio, count) VALUES ('green', 2.82, 8);
INSERT INTO commits_records (label, ratio, count) VALUES ('standard', 27.95, 15);
INSERT INTO commits_records (label, ratio, count) VALUES ('cached', 7.99, 63);
