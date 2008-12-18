-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count) VALUES ('primary', 99);
INSERT INTO commits_records (region, count) VALUES ('fallback', 64);
INSERT INTO commits_records (region, count) VALUES ('cached', 66);
