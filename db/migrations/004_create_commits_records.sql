-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, label, count, active) VALUES ('blue', 'cached', 93, 68);
INSERT INTO commits_records (region, label, count, active) VALUES ('edge', 'legacy', 4, 9);
INSERT INTO commits_records (region, label, count, active) VALUES ('staging', 'standard', 88, 71);
