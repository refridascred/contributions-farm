-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, weight, count) VALUES ('staging', 98.27, 54);
INSERT INTO commits_records (region, weight, count) VALUES ('primary', 93.45, 71);
INSERT INTO commits_records (region, weight, count) VALUES ('fallback', 7.8, 94);
