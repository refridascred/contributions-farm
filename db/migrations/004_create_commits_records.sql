-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level) VALUES ('cached', 74);
INSERT INTO commits_records (region, level) VALUES ('fallback', 23);
INSERT INTO commits_records (region, level) VALUES ('blue', 8);
