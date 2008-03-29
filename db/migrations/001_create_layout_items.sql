-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, score, owner, active) VALUES ('open', 93.86, 37.75, 'latest', 71);
INSERT INTO layout_items (token, ratio, score, owner, active) VALUES ('eu-west', 98.52, 70.22, 'standard', 68);
INSERT INTO layout_items (token, ratio, score, owner, active) VALUES ('staging', 38.17, 39.47, 'primary', 73);
