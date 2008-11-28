-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, score, count, token) VALUES (37.21, 'blue', 38.32, 43, 'stable');
INSERT INTO layout_items (weight, label, score, count, token) VALUES (98.02, 'fallback', 76.28, 87, 'green');
