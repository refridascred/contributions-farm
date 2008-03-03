-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, active, label) VALUES (96, 5, 'blue');
INSERT INTO commits_records (count, active, label) VALUES (81, 74, 'legacy');
INSERT INTO commits_records (count, active, label) VALUES (44, 12, 'standard');
