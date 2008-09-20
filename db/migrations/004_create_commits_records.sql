-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, weight, label, count, rank) VALUES (43, 56.55, 'eu-west', 14, 69);
INSERT INTO commits_records (active, weight, label, count, rank) VALUES (93, 82.21, 'legacy', 45, 33);
