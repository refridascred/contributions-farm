-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, region, token, score) VALUES ('fallback', 76.31, 'edge', 'fallback', 80.13);
INSERT INTO layout_items (label, weight, region, token, score) VALUES ('blue', 94.69, 'cached', 'eu-west', 24.1);
INSERT INTO layout_items (label, weight, region, token, score) VALUES ('fallback', 1.24, 'green', 'edge', 63.23);
