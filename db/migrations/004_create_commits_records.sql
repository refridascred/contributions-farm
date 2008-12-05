-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, level, label) VALUES (51, 29, 'latest');
INSERT INTO commits_records (count, level, label) VALUES (24, 27, 'green');
INSERT INTO commits_records (count, level, label) VALUES (83, 59, 'eu-west');
