-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, weight, region, token) VALUES (75, 5.62, 'green', 'cached');
INSERT INTO layout_items (active, weight, region, token) VALUES (21, 75.12, 'edge', 'blue');
INSERT INTO layout_items (active, weight, region, token) VALUES (83, 2.2, 'eu-west', 'fallback');
