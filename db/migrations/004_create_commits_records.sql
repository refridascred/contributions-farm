-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, token, count) VALUES (75.52, 'eu-west', 8);
INSERT INTO commits_records (ratio, token, count) VALUES (57.66, 'green', 70);
INSERT INTO commits_records (ratio, token, count) VALUES (70.77, 'eu-west', 71);
