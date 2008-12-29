-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, label, region) VALUES (99, 'edge', 'local');
INSERT INTO commits_records (count, label, region) VALUES (6, 'local', 'edge');
INSERT INTO commits_records (count, label, region) VALUES (3, 'cached', 'edge');
