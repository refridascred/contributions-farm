-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, token) VALUES (83.22, 73.06, 'fallback');
INSERT INTO layout_items (ratio, weight, token) VALUES (76.58, 42.37, 'edge');
INSERT INTO layout_items (ratio, weight, token) VALUES (89.45, 63.9, 'legacy');
