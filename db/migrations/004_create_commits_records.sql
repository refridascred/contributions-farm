-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, count, active, ratio, level) VALUES ('cached', 85, 4, 10.84, 16);
INSERT INTO commits_records (label, count, active, ratio, level) VALUES ('edge', 63, 32, 18.09, 45);
