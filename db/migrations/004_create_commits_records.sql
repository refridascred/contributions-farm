-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, label, weight) VALUES (53, 'eu-west', 13.13);
INSERT INTO commits_records (level, label, weight) VALUES (77, 'local', 75.11);
INSERT INTO commits_records (level, label, weight) VALUES (99, 'strict', 22.64);
