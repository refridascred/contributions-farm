-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, level, label, active) VALUES ('cached', 66, 'strict', 5);
INSERT INTO commits_records (token, level, label, active) VALUES ('fallback', 11, 'legacy', 92);
INSERT INTO commits_records (token, level, label, active) VALUES ('legacy', 2, 'green', 6);
