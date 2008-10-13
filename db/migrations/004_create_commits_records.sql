-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, ratio, region, active) VALUES ('strict', 61.27, 89.2, 'blue', 55);
INSERT INTO commits_records (token, weight, ratio, region, active) VALUES ('latest', 46.61, 72.5, 'green', 52);
