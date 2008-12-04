-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, label, level) VALUES (82, 'open', 23);
INSERT INTO commits_records (active, label, level) VALUES (92, 'standard', 27);
INSERT INTO commits_records (active, label, level) VALUES (90, 'fallback', 5);
