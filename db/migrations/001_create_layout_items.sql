-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, count, token) VALUES ('edge', 0.63, 9, 'open');
INSERT INTO layout_items (label, weight, count, token) VALUES ('cached', 43.61, 53, 'edge');
INSERT INTO layout_items (label, weight, count, token) VALUES ('open', 37.61, 16, 'fallback');
