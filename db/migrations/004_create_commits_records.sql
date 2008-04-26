-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, weight) VALUES ('cached', 'eu-west', 73.31);
INSERT INTO commits_records (token, label, weight) VALUES ('local', 'legacy', 91.33);
INSERT INTO commits_records (token, label, weight) VALUES ('legacy', 'local', 17.04);
