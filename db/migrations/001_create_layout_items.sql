-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, token, ratio, label, weight) VALUES ('edge', 'strict', 83.74, 'stable', 85.31);
INSERT INTO layout_items (owner, token, ratio, label, weight) VALUES ('standard', 'fallback', 54.85, 'local', 88.0);
INSERT INTO layout_items (owner, token, ratio, label, weight) VALUES ('stable', 'blue', 53.66, 'open', 14.83);
