-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio) VALUES (74, 32.87);
INSERT INTO commits_records (active, ratio) VALUES (96, 9.24);
INSERT INTO commits_records (active, ratio) VALUES (68, 13.75);
