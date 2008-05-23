-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, label, score) VALUES (58.49, 3.23, 'edge', 66.34);
INSERT INTO layout_items (ratio, weight, label, score) VALUES (68.74, 79.73, 'cached', 63.09);
