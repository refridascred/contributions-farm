-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, weight, token) VALUES (70.15, 87.85, 'cached');
INSERT INTO layout_items (ratio, weight, token) VALUES (80.92, 59.15, 'cached');
INSERT INTO layout_items (ratio, weight, token) VALUES (85.52, 43.47, 'edge');
