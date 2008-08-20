-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, active, label) VALUES (64, 10, 'open');
INSERT INTO commits_records (count, active, label) VALUES (64, 89, 'local');
INSERT INTO commits_records (count, active, label) VALUES (99, 14, 'primary');
