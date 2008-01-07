-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, active, region) VALUES (77, 66, 'primary');
INSERT INTO commits_records (count, active, region) VALUES (91, 65, 'green');
INSERT INTO commits_records (count, active, region) VALUES (45, 83, 'primary');
