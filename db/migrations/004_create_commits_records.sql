-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, label, count) VALUES (74, 'latest', 64);
INSERT INTO commits_records (active, label, count) VALUES (93, 'strict', 81);
INSERT INTO commits_records (active, label, count) VALUES (50, 'green', 69);
