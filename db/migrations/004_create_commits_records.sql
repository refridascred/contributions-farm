-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, ratio) VALUES (44, 'staging', 49.91);
INSERT INTO commits_records (level, label, ratio) VALUES (69, 'staging', 57.75);
INSERT INTO commits_records (level, label, ratio) VALUES (96, 'edge', 37.95);
