-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, score, level, active) VALUES ('latest', 'open', 54.85, 34, 24);
INSERT INTO layout_items (label, token, score, level, active) VALUES ('strict', 'local', 75.9, 61, 3);
INSERT INTO layout_items (label, token, score, level, active) VALUES ('green', 'edge', 64.44, 22, 55);
