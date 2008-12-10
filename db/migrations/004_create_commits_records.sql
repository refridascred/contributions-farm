-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, label, level) VALUES (32, 'cached', 19);
INSERT INTO commits_records (active, label, level) VALUES (65, 'edge', 41);
INSERT INTO commits_records (active, label, level) VALUES (7, 'primary', 85);
