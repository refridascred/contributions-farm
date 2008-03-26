-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, level) VALUES (94, 'blue', 19);
INSERT INTO commits_records (active, region, level) VALUES (89, 'fallback', 87);
INSERT INTO commits_records (active, region, level) VALUES (69, 'local', 33);
