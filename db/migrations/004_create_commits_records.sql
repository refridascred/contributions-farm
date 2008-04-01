-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, weight) VALUES ('stable', 'green', 2.81);
INSERT INTO commits_records (token, label, weight) VALUES ('blue', 'fallback', 84.35);
