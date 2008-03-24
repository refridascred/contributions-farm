-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, label) VALUES (55, 'eu-west', 'blue');
INSERT INTO commits_records (active, region, label) VALUES (89, 'blue', 'blue');
INSERT INTO commits_records (active, region, label) VALUES (58, 'eu-west', 'primary');
