-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, score, label) VALUES (89.86, 43.32, 'strict');
INSERT INTO layout_items (ratio, score, label) VALUES (61.32, 83.23, 'strict');
INSERT INTO layout_items (ratio, score, label) VALUES (56.83, 47.01, 'edge');
